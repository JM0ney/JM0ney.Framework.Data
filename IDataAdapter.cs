//
//  Do you like this project? Do you find it helpful? Pay it forward by hiring me as a consultant!
//  https://jason-iverson.com
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JM0ney.Framework.Data {
    public interface IDataAdapter {

        Result<int> Delete<TDataObject>( Guid identity )
            where TDataObject : class, IDataObject, new();

        Result<IEnumerable<TDataObject>> List<TDataObject>( )
            where TDataObject : class, IDataObjectBase, new();

        Result<IEnumerable<TDataObject>> ListBy<TDataObject>( String fieldName, Object fieldValue )
            where TDataObject : class, IDataObjectBase, new();

        Result<IEnumerable<TDataObject>> ListBy<TDataObject>( params KeyValuePair<String, Object>[ ] keysAndValues )
            where TDataObject : class, IDataObjectBase, new();

        Result<TDataObject> Load<TDataObject>( Guid identity )
            where TDataObject : class, IDataObjectBase, new();

        Result<int> Save<TDataObject>( TDataObject dataObject )
            where TDataObject : class, IDataObject, new();

        Result<int> AssertMapping( IDataObjectMapping mappedObject, bool ensureExists );

        Result<System.Data.DataSet> ExecuteFill( String commandText, params KeyValuePair<String, Object>[ ] parameters );

        Result<int> ExecuteStatement( String commandText, params KeyValuePair<String, Object>[ ] parameters );

    }

}
