class CreateMatriculas < ActiveRecord::Migration
  def change
    create_table :matriculas do |t|
      t.references :curso
      t.references :estudiante

      t.timestamps
    end
    add_index :matriculas, :curso_id
    add_index :matriculas, :estudiante_id
  end
end
