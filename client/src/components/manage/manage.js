import React from 'react';
import './manage.css';

const Manage = props => {
  console.log(props);
  return (
    <div className="row">
      <div className="col-12">
        <div className="jumbotron">
          <h1 className="display-4">Manage your products</h1>
          <p className="lead">Search, select and manage your products</p>
          <hr className="my-4" />
        </div>
      </div>
    </div>
  );
};

export default Manage;
