﻿//
//  Do you like this project? Do you find it helpful? Pay it forward by hiring me as a consultant!
//  https://jason-iverson.com
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM0ney.Framework.Data {

    public interface ICloneable {
        
        bool IsCloned { get; }

        bool ShouldClone( );

        void ConfigureClone( );

        IList<ICloneable> GetCloneableChildren( );

        void PostCloneCleanup( );

    }

}
