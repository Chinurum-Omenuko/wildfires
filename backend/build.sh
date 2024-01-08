#!/usr/bin/env bash
# exit on error
set -o errexit

# navigate to the backend directory
cd backend

# install dependencies
pip install -r requirements.txt

# collect static files and apply database migrations
python manage.py collectstatic --no-input
python manage.py migrate
