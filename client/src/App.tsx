import { useEffect, useState } from 'react';
import { List, ListItem, ListItemText, Typography } from '@mui/material';
import './App.css'
import axios from 'axios';

function App() {
  const [activities, setActivities] = useState<Activity[]>([]);

  useEffect(() => {
    axios.get<Activity[]>('https://localhost:5001/api/activities')
      .then(response => {
        setActivities(response.data);
      });
  }, []);

  return (
      <>
        <Typography variant='h3'>DotNet and React</Typography>
        <List>
          {activities.map((activity) => (
            <ListItem key={activity.id}>
              <ListItemText>{activity.title}</ListItemText>
            </ListItem>
          ))}
        </List>
      </>
  )
}

export default App
