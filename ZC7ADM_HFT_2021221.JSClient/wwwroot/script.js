let employees = [];

getData();

async function getData() {
    await fetch('http://localhost:31877/employee')
    .then(x => x.json())
    .then(y => {
        employees = y;
        console.log(employees)
        display();
    });
}



function display() {
    employees.forEach(t =>
    {
        document.getElementById('resultarea')
            .innerHTML += "<tr><td>" + t.name + "</td><td>" + t.salary + "</td><td>" + t.employeeId + "</td></tr>";
    })
}

function create()
{
    let name = document.getElementById('name').value;
    fetch('http://localhost:31877/employee', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(
            {
                name: name,
                salary: salary,
                employeeId: employeeId
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