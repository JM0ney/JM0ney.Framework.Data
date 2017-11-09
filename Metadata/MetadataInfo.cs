//
//  Do you like this project? Do you find it helpful? Pay it forward by hiring me as a consultant!
//  https://jason-iverson.com
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM0ney.Framework.Data.Metadata {

    /// <summary>
    /// Facilitates the transfer of data for an object, to whatever persistence medium is in use (e.g. database, JSON, XML, etc)
    /// </summary>
    public class MetadataInfo {

        #region Fields

        private String _FriendlyNameSingular = String.Empty;
        private String _FriendlyNamePlural = String.Empty;
        private String _DataObjectNameSingular = String.Empty;
        private String _DataObjectNamePlural = String.Empty;
        private String _DataObjectSchemaName = String.Empty;

        #endregion Fields

        #region Constructor(s)

        /// <summary>
        /// Constructs a new MetadataInfo object 
        /// </summary>
        /// <param name="nameSingular">Singular name for this object.  Serves as both the Friendly and DataObject name</param>
        /// <param name="namePlural">Plural name for this object.  Serves as both the friendly and DataObject name</param>
        /// <param name="schemaName"></param>
        public MetadataInfo( String nameSingular, String namePlural, String schemaName ) :
            this( nameSingular, namePlural, schemaName, nameSingular, namePlural ) {
        }

        /// <summary>
        /// Constructs a new MetadataInfo object
        /// </summary>
        /// <param name="friendlyNameSingular">Friendly, singular name for this object (e.g. Message)</param>
        /// <param name="friendlyNamePlural">Friendly, plural name for this object (e.g. Messages)</param>
        /// <param name="dataObjectSchemaName">A name used to further qualify this record with the persistence medium</param>
        /// <param name="dataObjectNameSingular">System Name in singular form for this data (e.g. MessageRecord)</param>
        /// <param name="dataObjectNamePlural">System Name in plural form for this data (e.g. MessageRecords)</param>
        public MetadataInfo( String friendlyNameSingular, String friendlyNamePlural, String dataObjectSchemaName, String dataObjectNameSingular, String dataObjectNamePlural ) {
            this.DataObjectNamePlural = dataObjectNamePlural;
            this.DataObjectNameSingular = dataObjectNameSingular;
            this.DataObjectSchemaName = dataObjectSchemaName;
            this.FriendlyNamePlural = friendlyNamePlural;
            this.FriendlyNameSingular = friendlyNameSingular;
        }

        #endregion Constructor(s)

        #region Properties

        /// <summary>
        /// A name used to further qualify this record with the persistence medium
        /// </summary>
        public String DataObjectSchemaName {
            get {
                return _DataObjectSchemaName;
            }
            protected set {
                this._DataObjectSchemaName = value;
            }
        }

        /// <summary>
        /// System Name in plural form for this data
        /// </summary>
        public String DataObjectNamePlural {
            get {
                return _DataObjectNamePlural;
            }
            protected set {
                this._DataObjectNamePlural = value;
            }
        }

        /// <summary>
        /// System Name in singular form for this data
        /// </summary>
        public String DataObjectNameSingular {
            get {
                return _DataObjectNameSingular;
            }
            protected set {
                this._DataObjectNameSingular = value;
            }
        }

        /// <summary>
        /// Friendly, plural name for this object
        /// </summary>
        public String FriendlyNamePlural {
            get {
                return _FriendlyNamePlural;
            }
            protected set {
                this._FriendlyNamePlural = value;
            }
        }

        /// <summary>
        /// Friendly, singular name for this object
        /// </summary>
        public String FriendlyNameSingular {
            get {
                return _FriendlyNameSingular;
            }
            protected set {
                this._FriendlyNameSingular = value;
            }
        }

        #endregion Properties

    }

}
