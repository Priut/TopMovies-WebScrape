using System;
/**************************************************************************
 *                                                                        *
 *  File:        Subcriber                                                *
 *  Copyright:   (c) 2022, Paraschiv Stefan                               *
 *  E-mail:      paraschiv.stefan@student.tuiasi.ro                       *
 *  Description: Class that notifies the Render class that the list of    *
 *  movies to be rendered in the interface has to be updated              *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    /// <summary>
    /// Class that defines the common interface that all the subscribers have to implement
    /// </summary>
    public interface Subscriber
    {
        /// <summary>
        /// Method update that any derived class has to implement
        /// </summary>
        /// <param name="cautare"></param>
        void Update(string cautare);
    }
}
