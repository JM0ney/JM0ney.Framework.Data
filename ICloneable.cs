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
