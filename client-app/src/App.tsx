import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import axios from 'axios';
import ListGroup from 'react-bootstrap/ListGroup'
import Container from 'react-bootstrap/Container'
import Navbar from 'react-bootstrap/Navbar'

import './App.css';

function App() {

  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/activities').then(response => {
      console.log(response);
      setActivities(response.data);  /// 
    })
  }, [])
  //  notice the empty brackets at the end. This ensures that useEffect will NOT run infinitely, but only one time.
  // It basically says, at least one variable is in these brackets has to change to run useEffect (other than the first time).
  // If we have nothing in the brackets, then it never runs after the first time.

  return (
    <div>
      <Navbar bg="dark" variant="dark">
        <Navbar.Brand>
          Bandit
        </Navbar.Brand>
      </Navbar>
      <Container>
        <ListGroup>
          {activities.map((activity: any) => (
            <ListGroup.Item key={activity.id}>
              {activity.title}
            </ListGroup.Item>
          ))}
        </ListGroup>
      </Container>
    </div>
  );
}

export default App;
