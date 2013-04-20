class Matricula < ActiveRecord::Base
	#attr_accessible :curso_id, :estudiante_id
  belongs_to :curso
  belongs_to :estudiante
  #has_many :estudiantes
  # attr_accessible :title, :body
end
