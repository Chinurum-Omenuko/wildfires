from django.db import models

# Create your models here.
class Report(models.Model):
    name = models.CharField(max_length=200)
    report = models.CharField(max_length=200)
    class Meta:
        verbose_name = 'Report'
        verbose_name_plural = 'Reports'

