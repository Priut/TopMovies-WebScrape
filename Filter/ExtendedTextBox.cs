/**************************************************************************
 *                                                                        *
 *  File:        Extended Text Box                                        *
 *  Copyright:   (c) 2022, Paraschiv Stefan                               *
 *  E-mail:      paraschiv.stefan@student.tuiasi.ro                       *
 *  Description: Class that extends TextBox so that it can have           *
 *               subscribers that are notified upon entering a character  *
 *               in the Extended Text Box                                 *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filter
{
    /// <summary>
    /// Class that extends TextBox so that it can have subscribers that are notified upon entering a character in the ExtendedTextBox
    /// </summary>
    public class ExtendedTextBox : TextBox
    {
        List<Subscriber> _subscriberList;
        int _subscriber = 0;

        /// <summary>
        /// Constructor ce apeleaza constructorul de baza al clasei TextBox si initializeaza lista de subscriberi cu o lista nula
        /// </summary>
        public ExtendedTextBox() : base()
        {
            _subscriberList = new List<Subscriber> { };
        }

        /// <summary>
        /// Metoda ce adauga un nou subscriber in lista de subscriberi
        /// </summary>
        /// <param name="newSubscriber"></param>
        public void AddSubscriber(Subscriber newSubscriber)
        {
            _subscriberList.Add(newSubscriber);
            _subscriber++;
        }

        /// <summary>
        /// Metoda ce returneaza lista de subscriberi
        /// </summary>
        /// <returns></returns>
        public List<Subscriber> GetSubscribers()
        {
            return _subscriberList;
        }

        /// <summary>
        ///  Metoda ce notifica fiecare subscriber din lista de subscriberi ca a fost facuta o schimbare a starii ExtendedTextBox-ului
        /// </summary>
        public void Notify()
        {
            string cautare = Text.ToString();
            for (int i = 0; i < _subscriber; i++)
            {
                _subscriberList[i].Update(cautare);
            }
        }

        /// <summary>
        /// Metoda ce sterge un anumit subscriber din lista de subscriberi
        /// </summary>
        /// <param name="delSubscriber"></param>
        public void DeleteSubscriber(Subscriber delSubscriber)
        {
            for (int i = 0; i < _subscriber; i++)
            {
                if (_subscriberList[i] == delSubscriber)
                {
                    _subscriber--;
                    _subscriberList.RemoveAt(i);
                }
            }
        }


    }
}
