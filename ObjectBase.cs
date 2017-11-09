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

    /// <summary>
    /// An Object to inherit from to abstract away much of the data persistence tasks related to Object Oriented solutions.
    /// </summary>
    public abstract class ObjectBase : IDataObject {

        #region Fields

        private Guid _Identity = Guid.Empty;
        private IDataAdapter _Adapter = null;

        #endregion Fields

        /// <summary>
        /// Returns a dictionary of values to be serialized to the persistence medium
        /// </summary>
        /// <returns></returns>
        public virtual Dictionary<String, Object> GetValues( ) {
            Dictionary<String, Object> dict = new Dictionary<String, Object>( );
            dict[ "Identity" ] = this.Identity;
            return dict;
        }

        /// <summary>
        /// Populates the object from the dataSet
        /// </summary>
        /// <param name="fieldNamePrefix"></param>
        /// <param name="deepLoad"></param>
        /// <param name="tableIndex"></param>
        /// <param name="rowIndex"></param>
        /// <param name="dataSet"></param>
        public virtual void Load( String fieldNamePrefix, bool deepLoad, int tableIndex, int rowIndex, System.Data.DataSet dataSet ) {
            this.Identity = dataSet.GetValue<Guid>( tableIndex, rowIndex, "Identity", fieldNamePrefix );
        }

        /// <summary>
        /// Saves the object to the persistence mediumm
        /// </summary>
        /// <returns></returns>
        public abstract Result Save( );

        /// <summary>
        /// Deletes the object from the persistence medium
        /// </summary>
        /// <returns></returns>
        public abstract Result Delete( );

        /// <summary>
        /// Returns metadata used in persistence medium related operations
        /// </summary>
        public abstract Metadata.MetadataInfo Metadata { get; }

        #region Properties

        /// <summary>
        /// Unique identifier of this Object
        /// </summary>
        public virtual Guid Identity {
            get {
                return _Identity;
            }

            set {
                this._Identity = value;
            }
        }

        /// <summary>
        /// Gets or sets the data adapter that is responsible for interacting with the persistence medium
        /// </summary>
        public IDataAdapter Adapter {
            get {
                return _Adapter;
            }
            set {
                this._Adapter =  value ;
            }
        }

        #endregion Properties
    }

}
