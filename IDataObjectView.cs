using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM0ney.Framework.Data {

    public interface IDataObjectView {

        String PrepareFieldNamePrefix( Metadata.MetadataInfo metadata );

    }

}
