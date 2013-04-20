class Prueba < ActiveRecord::Base
  attr_accessible :calificacion, :comentario, :curso, :duracion, :estado, :fecha, :nombre, :preguntas, :curso_id

  belongs_to :curso

  has_many :respuestas

  #has_many :estudiantes, :through => :respuestas
end
