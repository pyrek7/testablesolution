pipeline {
    agent any
    environment {
       dotnet = '"C:\\Program Files\\dotnet\\dotnet.exe"'
    }


    stages {
        stage('Build solution') {
            steps {
                dir("Math.Tests")
                bat "${dotnet} build"
            }
        }
        stage('Test Solution') {
            steps {
                dir("Math.Tests")
                bat "${dotnet} test"
            }
        }
        stage('Clean solution') {
            steps {
                dir("Math.Tests")
                bat "${dotnet} build"
            }
        }
    }
}
