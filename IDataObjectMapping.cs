using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM0ney.Framework.Data {

    public interface IDataObjectMapping : IDataObjectBase {

        Guid GetIdentity( );

        Guid GetParentIdentity( );

        Dictionary<String, Object> GetAdditionalValues( );

        String SchemaName { get; }

        String ParentDataObjectNameSingular { get; }

    }

}
