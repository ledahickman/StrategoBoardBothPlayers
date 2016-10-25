using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StrategoBoardBothPlayers
{
    class Pieces
    {
        private string name;
        private int value;
        private Icon image;

        Pieces(string name, int value) {
            this.name = name;
            this.value = value;
            setIcon();
        }   

        private void setIcon() {
            switch (name)
            {
                case "Flag":
                    this.image = new Icon("General.png");
                    break;
                case "Bomb":
                    this.image = new Icon("General.png");
                    break;
                case "Spy":
                    this.image = new Icon("General.png");
                    break;
                case "Scout":
                    this.image = new Icon("General.png");
                    break;
                case "Miner":
                    this.image = new Icon("General.png");
                    break;
                case " Sergeant":
                    this.image = new Icon("General.png");
                    break;
                case "Lieutenant":
                    this.image = new Icon("General.png");
                    break;
                case "Captain":
                    this.image = new Icon("General.png");
                    break;
                case "Major":
                    this.image = new Icon("General.png");
                    break;
                case "Colonel":
                    this.image = new Icon("General.png");
                    break;
                case "General":
                    this.image = new Icon("General.png");
                    break;
                case "Marshall":
                    this.image = new Icon("General.png");
                    break;
                default:
                    Console.Out.Write("Wrongo");
                    break;




            }

        }

        }

    


    }

