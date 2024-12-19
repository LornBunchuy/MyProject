from django.template import loader
from django.http import HttpResponse
from django.shortcuts import render

def homes(request):
  template = loader.get_template('Home.html')
  return HttpResponse(template.render())
def home(request):
  return render(request, 'Home.html')
def book(request):
  return render(request, 'Book.html')
def details(request):
  return render(request, 'Details.html')
def about(request):
  return render(request, 'AboutUs.html')
def contact(request):
  return render(request, 'Contact.html')
def login(request):
  return render(request, 'LogIn.html')
def logout(request):
  return render(request, 'LogOut.html')