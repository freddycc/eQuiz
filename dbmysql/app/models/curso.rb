class Curso < ActiveRecord::Base
  attr_accessible :codigo, :descripcion, :nombre, :profesore_id

  belongs_to :profesore

  has_many :pruebas

  #has_and_belongs_to_many :estudiantes
  has_many :matriculas
  has_many :estudiantes, :through => :matriculas
end
