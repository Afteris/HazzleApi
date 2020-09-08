import React, { useState } from 'react'

const AddUser = (props) => {
    const initialFormState = { id: null, name: '', username: '' }
    const [user, setUser] = useState(initialFormState)

    const handleInputChange = (event) => {
        const { name, value } = event.target

        setUser({ ...user, [name]: value })
    }

    return (
        <form
            onSubmit={(event) => {
                event.preventDefault()
                if (!user.name || !user.username) return

                props.addUser(user)
                setUser(initialFormState)
            }}
        >
            <label>Name</label>
            <input
                type="text"
                name="name"
                value={user.name}
                onChange={handleInputChange}
            />
            <label>Username</label>
            <input
                type="text"
                name="username"
                value={user.username}
                onChange={handleInputChange}
            />
            <label>Age</label>
            <input
                type="number"
                name="age"
                value={user.age}
                onChange={handleInputChange}
            />
            <label>Job title</label>
            <input
                type="text"
                name="jobTitle"
                value={user.jobTitle}
                onChange={handleInputChange}
            />
            <button className="btn btn-primary">Add new user</button>
        </form>
    )
}

export default AddUser