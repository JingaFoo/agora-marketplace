import React from 'react';
import { NavLink } from 'react-router-dom';
import '../categories/categories.css';

const Dashboard = () => {
  return (
    <div className="categories">
      <div className="row">
        <div className="col-12">
          <div className="jumbotron">
            <h1 className="display-4">Welcome to your Dashboard</h1>
            <p className="lead">Create, View and Manage your Products using the Dashboard</p>
            <hr className="my-4" />
          </div>
        </div>
      </div>
      <div className="container category-content">
        <div className="row inner-category">
          <div className="col-4">
            <div className="category-box">
              <h4><NavLink to="/Manage/Create"><span className="category-title">Create</span></NavLink></h4>
              <hr />
            </div>
          </div>
          <div className="col-4">
            <div className="category-box">
              <h4><NavLink to="/Manage/Products"><span className="category-title">Manage</span></NavLink></h4>
              <hr />
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Dashboard;
