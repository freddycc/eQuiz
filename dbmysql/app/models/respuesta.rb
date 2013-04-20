class Respuesta < ActiveRecord::Base
  #attr_accessible :estudiante_id, :prueba_id, :respuesta, :calificacion
  belongs_to :estudiante
  belongs_to :prueba
end
