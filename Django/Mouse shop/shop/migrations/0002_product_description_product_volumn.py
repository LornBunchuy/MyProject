# Generated by Django 5.1.1 on 2024-09-11 11:27

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('shop', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='product',
            name='description',
            field=models.CharField(default='', max_length=255),
            preserve_default=False,
        ),
        migrations.AddField(
            model_name='product',
            name='volumn',
            field=models.CharField(default='', max_length=10),
            preserve_default=False,
        ),
    ]