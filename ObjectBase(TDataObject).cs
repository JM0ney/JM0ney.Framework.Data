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
    /// <typeparam name="TDataObject"></typeparam>
    public abstract class ObjectBase<TDataObject> : ObjectBase 
        where TDataObject : class, IDataObject, new() {

        protected abstract TDataObject AsDataObject { get; }

        /// <summary>
        /// Saves the object to the persistence mediumm
        /// </summary>
        /// <returns></returns>
        public override Result Save( ) {
            Result result = this.Adapter.Save( this.AsDataObject );
            return result;
        }

        /// <summary>
        /// Deletes the object from the persistence medium
        /// </summary>
        /// <returns></returns>
        public override Result Delete( ) {
            Result result = this.Adapter.Delete<TDataObject>( this.Identity );
            return result;            
        }

    }

}
