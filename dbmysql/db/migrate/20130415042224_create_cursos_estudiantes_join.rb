class CreateCursosEstudiantesJoin < ActiveRecord::Migration
  def up
  	create_table :cursos_estudiantes, :id=>false do |t|
  		t.references :curso_id
  		t.references :estudiante_id
  	end
  	add_index :cursos_estudiantes, :curso_id
    add_index :cursos_estudiantes, :estudiante_id
  end

  def down
  	drop_table :cursos_estudiantes
  end
end
