import React, { useState, useEffect } from 'react';
import axios from "axios";
import {Header, List} from "semantic-ui-react";

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/activities').then((response) => {
      console.log(response);
      setActivities(response.data);
    })
        .catch(console.log)
  }, []);
  
  return (
      <div>
        <Header as='h2' icon='users' content='Activities' />
        <List bulleted>
          {
            activities.map((activity: any) => {
              return <List.Item key={activity.id}>{activity.title}</List.Item>
            })
          }
        </List>
      </div>
  );
}

export default App;
