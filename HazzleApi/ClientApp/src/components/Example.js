﻿import React, { useState, useEffect } from 'react';
import AddUser from './AddUser';


export function Example() {
   
    const [users, setUsers] = useState([]);
    const [loading, setLoading] = useState(true);
    useEffect(() => {
        (async () => {
            const response = await fetch(`api/example`);
            const data = await response.json();
            setUsers(data);
            setLoading(false);
        })();
    }, []);
    const handleDelete = (id) => {
        fetch(`api/example/${id}`, {
            method: 'DELETE'
        }).then(res => {
            const del = users.filter(user => id !== user.id)
            setUsers(del)
        }).then(data => console.log(data));
    };
    const create = user => {
        console.log(JSON.stringify(user));
        fetch('api/example', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        }).then(res => {
            console.log(res);
        })
    };
    const addUser = (user) => {
        
        user.id = users.length + 1;
        create(user);
        setUsers([...users, user])
    }
    return (
        <div>
            <div>
                <AddUser addUser={addUser} />
            </div>
            <div>
                {loading ? renderLoadingMessage() :
                <table>
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Username</th>
                            <th>Age</th>
                            <th>Job title</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                        {users.length > 0 ? (
                            users.map((user) => (
                                <tr key={user.id}>
                                    <td>{user.name}</td>
                                    <td>{user.username}</td>
                                    <td>{user.age}</td>
                                    <td>{user.jobTitle}</td>
                                    <td>
                                        <button className="btn btn-primary" onClick={() => handleDelete(user.id)}>Delete</button>
                                    </td>
                                </tr>
                            ))
                        ) : (
                                <tr>
                                    <td colSpan={3}>No users</td>
                                </tr>
                            )}
                    </tbody>
                </table>}
            </div>
        </div>
    );
}
function renderLoadingMessage() {
    return (<p><em>Loading...</em></p>);
}