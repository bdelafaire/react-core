import React, { Component } from 'react';
import { BrowserRouter as Router, Route } from 'react-router-dom'
//import { Layout } from './containers/Layout/Layout';
import Home  from './containers/Home/Home';
import Student from './containers/Student/Student';
import Appbar from './components/Appbar/Appbar'

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
        <Router>
            <>
            <Appbar/>
                <Route path="/" component={Home} />
                <Route path="/student" component={Student} />
            </>
        </Router>
    );
  }
}
