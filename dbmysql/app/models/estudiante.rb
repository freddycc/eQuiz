class Estudiante < ActiveRecord::Base
  attr_accessible :apellidos, :cedula, :email, :id, :nombre, :password, :username

  #has_and_belongs_to_many :cursos
  has_many :matriculas
  has_many :cursos, :through => :matriculas

  has_many :respuestas
  has_many :pruebas, :through => :respuestas
end
