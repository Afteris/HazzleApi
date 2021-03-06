import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Statistics } from './components/Statistics';
import { Example } from './components/Example';

import './custom.css'


export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/statistics' component={Statistics} />
        <Route path='/example' component={() => <Example/>} /> 
      </Layout>
    );
  }
}
