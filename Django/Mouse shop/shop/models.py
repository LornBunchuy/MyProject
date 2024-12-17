from django.db import models

class Category(models.Model):
    name = models.CharField(max_length=30)

    def __str__(self):
        return f"{self.name} ({self.id})"

# Create your models here
class Product(models.Model):
    name = models.CharField(max_length=30)
    category = models.ForeignKey(Category, on_delete=models.CASCADE)
    price = models.FloatField()
    description = models.CharField(max_length=255)
    image = models.CharField(max_length=255)

    def __str__(self):
        return f"{self.name} ({self.id})"