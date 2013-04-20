class AddCalificacionToRespuestas < ActiveRecord::Migration
  def change
    add_column :respuestas, :calificacion, :string
  end
end
