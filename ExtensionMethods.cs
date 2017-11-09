//
//  Do you like this project? Do you find it helpful? Pay it forward by hiring me as a consultant!
//  https://jason-iverson.com
//
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM0ney.Framework.Data {
    public static class ExtensionMethods {

        private static String GetFieldName( String fieldName, String fieldNamePrefix ) {
            if ( String.IsNullOrWhiteSpace( fieldNamePrefix ) )
                return fieldNamePrefix + fieldName;
            else
                return fieldName;
        }


        public static bool ColumnExists( this DataSet dataSet, int tableIndex, String columnName ) {
            bool exists = dataSet.Tables[ tableIndex ].Columns[ columnName ] != null;
            return exists;
        }

        public static bool TableExists( this DataSet dataSet, int tableIndex ) {
            return
                dataSet.Tables.Count > 0 &&
                tableIndex < dataSet.Tables.Count;
        }


        public static TType GetValue<TType>( this DataSet dataSet, int tableIndex, int rowIndex, String fieldName, String fieldNamePrefix ) {
            TType returnValue = default( TType );
            String realFieldName = GetFieldName( fieldName, fieldNamePrefix );
            Object realValue = dataSet.Tables[ tableIndex ].Rows[ rowIndex ][ realFieldName ];
            Type realType = typeof( TType );

            if ( realType.IsEnum ) {
                String stringValue = String.Empty;
                if ( realValue != null )
                    stringValue = realValue.ToString( );
                returnValue = ( TType ) Enum.Parse( realType, stringValue );
            }
            else {
                returnValue = ( TType ) realValue;
            }

            return returnValue;
        }

        public static bool IsDBNull( this DataSet dataSet, int tableIndex, int rowIndex, String fieldName, String fieldNamePrefix ) {
            return dataSet.Tables[ tableIndex ].Rows[ rowIndex ].IsNull( GetFieldName( fieldName, fieldNamePrefix ) );
        }


        public static String RemoveDashes( this Guid guidValue ) {
            return guidValue.ToString( ).Replace( "-", String.Empty );
        }

    }
}
