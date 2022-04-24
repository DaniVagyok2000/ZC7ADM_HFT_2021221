let employees = [];
let connection = null;
getData();

function setupSignalR() {
    connection = new signalR.HubConnectionBuilder()
        .withUrl("http://localhost:31877/hub")
        .configureLogging(signalR.LogLevel.Information)
        .build();

    connection.on
        (
            "EmployeeCreated", (user, message) => {
            console.log(user);
            console.log(message);
        });

    connection.onclose
        (async () => {
            await start();
        });
    start();

}

async function start() {
    try {
        await connection.start();
        console.log("SignalR Connected.");
    } catch (err) {
        console.log(err);
        setTimeout(start, 5000);
    }
};

async function getData() {
    await fetch('http://localhost:31877/employee')
        .then(x => x.json())
        .then(y => {
            employees = y;
            //console.log(employees)
            display();
        });
}


function display() {
    document.getElementById('resultarea').innerHTML = "";
    employees.forEach(t => {
        document.getElementById('resultarea')
            .innerHTML += "<tr><td>" + t.name + "</td><td>" + t.salary + "</td><td>" + t.restaurantId + "</td><td>" +
            `<button type="button" onclick="remove(${t.employeeId})">Delete</button>` + "," + `<button type="button" onclick="update(${t.employeeId})">Update</button>`
            + "</td></tr>";
    })
}

function remove(id) {
    fetch('http://localhost:31877/employee/' + id, {
        method: 'DELETE',
        headers: { 'Content-Type': 'application/json', },
        body: null
    })
        .then(response => response)
        .then(data => {
            console.log('Success:', data);
            getData();
        })
        .catch((error) => { console.error('Error:', error); });

}

function update(id) {
    let Name = document.getElementById('employeename').value;
    let sal = document.getElementById('employeesalary').value;
    let restId = document.getElementById('restaurantid').value;
    let empid = id;
    fetch('http://localhost:31877/employee', {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(
            {
                name: Name,
                salary: sal,
                restaurantId: restId,
                employeeId: empid
            }),
    })
        .then(response => response)
        .then(data => {
            console.log('Success:', data);
            getData();
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}

function create() {
    let Name = document.getElementById('employeename').value;
    let sal = document.getElementById('employeesalary').value;
    let restId = document.getElementById('restaurantid').value;
    fetch('http://localhost:31877/employee', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(
            {
                name: Name,
                salary: sal,
                restaurantId: restId
            }),
    })
        .then(response => response)
        .then(data => {
            console.log('Success:', data);
            getData();
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}