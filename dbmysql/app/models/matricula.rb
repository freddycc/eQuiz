class Matricula < ActiveRecord::Base
  belongs_to :curso
  belongs_to :estudiante
  #has_many :estudiantes
  # attr_accessible :title, :body
end
