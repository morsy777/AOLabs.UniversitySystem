-- TEST CASE
INSERT INTO Students (
    Id,
    FullName,
    NationalId,
    Email,
    Gender,
    BirthDate,
    AcadimcYear,
    [Level],
    GpaType,
    UniversityId,
    FacultyId,
    DepartmentId,
    SpecializationId
) 
VALUES (
    NEWID(), 
    'Mohamed Morsi',
    '12345678901234',
    'test@example.com',
    0, 
    '2000-02-02',
    3,
    300,
    1, 
    '09d78845-4820-4857-e0ce-08dd9f959bdc',
    'de09ee46-b176-4055-9a03-08dd9f96a66c',
    'd6b88b73-7328-4d68-3830-08dd9f973034',
    '900db076-8500-4980-93a5-08dd9f989766'
);