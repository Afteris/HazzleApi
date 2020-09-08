import React, { useState, useEffect } from 'react';


export function Example() {
   
    const [users, setUsers] = useState([]);
    const [loading, setLoading] = useState(true);
    useEffect(() => {
        (async () => {
            const response = await fetch("api/example");
            const data = await response.json();
            setUsers(data);
            setLoading(false);
        })();
    }, []);

    const handleDelete = (id) => {

        fetch(`api/example/${id}`, { method: 'DELETE' }).then(res => {
            const del = users.filter(user => id !== user.id)
            setUsers(del)
        })
    };

    return (
        <div>
            
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