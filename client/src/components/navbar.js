import React from 'react';
import './navbar.css';

const Navbar = () => {
  return (
    <div className="main-nav">
      <nav className="navbar navbar-expand-sm">
        <a className="navbar-brand" href="/"><img src="agora-icon.png" alt="" /></a>
        <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="/navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <i className="ion-md-menu"></i>
        </button>
        <div className="collapse navbar-collapse" id="navbarSupportedContent">
            <div className="nav-right d-none d-sm-block">
                <div className="row no-gutters">
                    <div className="col-md-3 col-sm-3">
                        <ul className="navbar-nav">
                            <li className="nav-item"><a className="nav-item nav-link" href="/categories">Categories</a></li>
                            <li className="nav-item"><a className="nav-item nav-link nav-border" href="/">Deals</a></li>
                        </ul>
                    </div>
                    <div className="col-md-9 col-sm-9 ml-auto">
                        <form className="form-inline">
                            <div className="input-group">
                                <input type="text" className="form-control" placeholder="Search for any product" />
                                <div className="input-group-append">
                                    <div className="form-group">
                                        <select className="custom">
                                            <option selected>All</option>
                                            <option>Fashion</option>
                                            <option>Electronics</option>
                                        </select>
                                    </div>
                                </div>
                                <div className="input-group-append">
                                    <button className="btn" type="button">
                                        <i className="ion-md-search nav-icon"></i>
                                    </button>
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
            <div className="d-none d-sm-block">
                <ul className="navbar-nav ml-auto">
                    <li className="nav-item"><a className="nav-item nav-link active" href="/dashboard">Dashboard</a></li>
                    <li className="nav-item"><a className="nav-item nav-link nav-border" href="/"><i className="ion-md-settings nav-icon"></i></a></li>
                </ul>
            </div>
            <div className="nav-dropdown nav-right d-block d-sm-none">
                <form>
                    <ul className="navbar-nav product-nav">
                        <li className="nav-item" ><a className="nav-item nav-link shop-links" href="/categories">Categories</a></li>
                        <li className="nav-item"><a className="nav-item nav-link shop-links" href="/">Deals</a></li>
                    </ul>
                    <div className="input-group search-bar">
                        <div className="input-group-append">
                            <button className="btn" type="button">
                                <i className="fas fa-search"></i>
                            </button>
                        </div>
                        <input type="text" className="form-control" placeholder="Search" />
                        <div className="input-group-append">
                            <div className="form-group">
                                <select>
                                    <option selected>All</option>
                                    <option>Fashion</option>
                                    <option>Electronics</option>
                                </select>
                            </div>
                        </div>
                    </div>
                    <ul className="navbar-nav product-nav">
                        <li className="nav-item"><a className="nav-item nav-link account-links" href="/dashboard">Dashboard</a></li>
                        <li className="nav-item"><a className="nav-item nav-link account-links" href="/settings">Settings</a></li>
                    </ul>
                </form>
            </div>
        </div>
      </nav>
    </div>
  );
}

export default Navbar;
