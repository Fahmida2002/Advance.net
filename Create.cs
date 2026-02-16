
@{
    ViewData["Title"] = "Create";
}

<!DOCTYPE html>
<html>
<head>
    <title>Create Student</title>
</head>
<body>

    <h1>Create Student</h1>

    <form method="post" action="">

        <label>Name:</label>
        <input type="text" id="Name" name="Name" required />
        <br /><br />

        <label>ID:</label>
        <input type="number" id="Id" name="Id" required />
        <br /><br />

        <label>CGPA:</label>
        <input type="number" step="0.01" id="CGPA" name="CGPA" required />
        <br /><br />

        <button type="submit">Submit</button>

    </form>

</body>
</html>
