﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    class Prichal
    {
        //код 4 лабораторной

        List<ClassArray<ITransport>> prichalStages;
        int countPlaces = 20;
        int placeSizeWidth = 210;
        int placeSizeHeight = 85;
        int currentLevel;

        public int getCurrentLevel { get { return currentLevel; } }
        public Prichal(int countStages)
        {
            //как добавить эл-ты в список
            prichalStages = new List<ClassArray<ITransport>>();
            ClassArray<ITransport> ship;
            for (int i = 1; i <= countStages; i++)
            {
                ship = new ClassArray<ITransport>(countStages, null);
                prichalStages.Add(ship);
            }

        }

        public void LevelDown()
        {
            if (currentLevel + 1 < prichalStages.Count)
            {
                currentLevel++;
            }
        }
        public void LevelUp()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }
        public int PutShipInPrichal(ITransport ship)
        {
            return prichalStages[currentLevel] + ship;
        }
        public ITransport GetShipInPrichal(int ticket)
        {
            return prichalStages[currentLevel] - ticket;
        }

        public void Draw(Graphics g)
        {

            DrawMarking(g);
            int i =0;
            foreach (var ship in prichalStages[currentLevel])
            {
                
                    ship.setPosition(5 + i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight - 15);
                    ship.drawShip(g);
                i++;
            }
        }
        public string[] SortMe()
        {
            string[] test = { "1", "2" };
            prichalStages.Sort();
            return test;
        }

        private void DrawMarking(Graphics g)
        {

            Pen pen = new Pen(Color.Black, 3);

            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue), (countPlaces / 5) * placeSizeWidth - 70, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);

            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {

                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
                    if (j < 5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i * placeSizeWidth + 30, j * placeSizeHeight + 20);
                    }
                }

                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }
        public bool SaveData(string filename)
        {
            try
            {
                if (File.Exists(filename))
                {

                    File.Delete(filename);

                }

                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {

                    using (BufferedStream bs = new BufferedStream(fs))
                    {

                        byte[] info = new UTF8Encoding(true).GetBytes("CountLeveles:" + prichalStages.Count + Environment.NewLine);
                        fs.Write(info, 0, info.Length);

                        foreach (var level in prichalStages)
                        {

                            info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                            fs.Write(info, 0, info.Length);
                            for (int i = 0; i < countPlaces; i++)
                            {

                                var ship = level[i];
                                if (ship != null)
                                {

                                    if (ship.GetType().Name == "Ship")
                                    {

                                        info = new UTF8Encoding(true).GetBytes("Ship:");
                                        fs.Write(info, 0, info.Length);

                                    }
                                    if (ship.GetType().Name == "CruiseLiner")
                                    {

                                        info = new UTF8Encoding(true).GetBytes("CruiseLiner:");
                                        fs.Write(info, 0, info.Length);

                                    }

                                    info = new UTF8Encoding(true).GetBytes(ship.GetInfo() + Environment.NewLine);
                                    fs.Write(info, 0, info.Length);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e) {
                throw e;
            }
            return true;

        }
        public bool LoadData(string filename)
        {
            try {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    string s = "";
                    using (BufferedStream bs = new BufferedStream(fs))
                    {
                        byte[] b = new byte[fs.Length];
                        UTF8Encoding temp = new UTF8Encoding(true);
                        while (bs.Read(b, 0, b.Length) > 0)
                        {
                            s += temp.GetString(b);
                        }

                    }
                    s = s.Replace("\r", "");
                    var strs = s.Split('\n');
                    try {
                        strs[0].Contains("CountLeveles:");
                        //считываем количество уровней
                        int count = Convert.ToInt32(strs[0].Split(':')[1]);
                        if (prichalStages != null)
                        {
                            prichalStages.Clear();

                        }

                        prichalStages = new List<ClassArray<ITransport>>(count);
                    }
                    catch(Exception) {
                        //если нет такой записи, то это не те данные
                        throw new DataErrorException();
                    }
                    int counter = -1;
                    for (int i = 1; i < strs.Length; ++i)
                    {
                        if (strs[i] == "Level")
                        {
                            counter++;
                            prichalStages.Add(new ClassArray<ITransport>(countPlaces, null));

                        }
                        else if (strs[i].Split(':')[0] == "Ship")
                        {
                            ITransport ship = new Ship(strs[i].Split(':')[1]);
                            int number = prichalStages[counter] + ship;
                            if (number == -1) { MessageBox.Show("Корабль -1", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return false; }

                        }
                        else if (strs[i].Split(':')[0] == "CruiseLiner")
                        {
                            ITransport ship = new CruiseLiner(strs[i].Split(':')[1]);
                            int number = prichalStages[counter] + ship;
                            if (number == -1) { MessageBox.Show("Лайнер -1", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return false; }

                        }
                    }

                }
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(ex.Message + "Файл не существует");
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException(ex.Message + "Директории не существует");
            }
            catch (DriveNotFoundException ex)
            {
                throw new DriveNotFoundException(ex.Message + "Попытка доступа к недоступному диску или данным совместного использования");
            }
            catch (EndOfStreamException ex)
            {
                throw new EndOfStreamException(ex.Message + "Попытка чтения за концом потока.");
            }
            catch (InternalBufferOverflowException ex)
            {
                throw new InternalBufferOverflowException(ex.Message + "Буфер переполнен!");
            }
            catch (InvalidDataException ex)
            {
                throw new InvalidDataException(ex.Message + "Недопустимый формат данных");
            }
            return false;
            }}
    }
   