class Respuesta < ActiveRecord::Base
  attr_accessible :estudiante_id, :prueba_id, :respuesta, :calificacion
  has_one :estudiante
  has_one :prueba
end
