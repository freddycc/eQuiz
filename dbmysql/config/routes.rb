Dbmysql::Application.routes.draw do
  resources :matriculas


  


  resources :pruebas


  resources :cursos


  resources :profesores


  resources :estudiantes

  #Actions of students
  match 'estudiantes/add' => 'estudiantes#add', :via => :post
  match 'estudiantes/estud' => 'estudiantes#estud', :via => :post

  #Actions of teachers
  match 'profesores/add' => 'profesores#add', :via => :post
  match 'profesores/prof' => 'profesores#prof', :via => :post
  #Actions of Cursos
    #obtiene estudiantes matriculados
  match 'cursos/:id/estudiantes' => 'cursos#estudiantes', :via => :get
    #obtiene estudiantes no matriculados
  match 'cursos/:id/noestudiantes' => 'cursos#noestudiantes', :via => :get
    #desenlasa un estudiante con un curso
  match 'cursos/:curso_id/:estudiante_id/delmatricula' => 'cursos#delmatricula', :via => :delete
    #obtiene las pruebas del curso
  match 'cursos/:id/pruebas' => 'cursos#pruebas', :via => :get

  #Actions of tests
    #obtiene pruebas activas del curso
  match 'cursos/:id/activas' => 'pruebas#activas', :via => :get
  match 'cursos/:id/inactivas' => 'pruebas#inactivas', :via => :get
  match 'pruebas/:id/updateprueba' => 'pruebas#updateinactiva', :via => :put

  #Actions of response
  match 'respuesta/:prueba_id/getrespuestas' => 'respuesta#getrespuestas', :via => :get
  match 'respuesta/:id/estudiantes' => 'respuesta#estudiantes', :via => :get
  match 'respuesta/:id' => 'respuesta#show', :via => :get
  match 'respuesta/:id' => 'respuesta#update', :via => :put
  match 'respuesta' => 'respuesta#create', :via => :post
  # The priority is based upon order of creation:
  # first created -> highest priority.

  # Sample of regular route:
  #   match 'products/:id' => 'catalog#view'
  # Keep in mind you can assign values other than :controller and :action
  # match ':controller/:action/:apellido/:cedula/:email/:nombre/:pass/:username.:format'
  # Sample of named route:
  #   match 'products/:id/purchase' => 'catalog#purchase', :as => :purchase
  # This route can be invoked with purchase_url(:id => product.id)

  # Sample resource route (maps HTTP verbs to controller actions automatically):
  #   resources :products

  # Sample resource route with options:
  #   resources :products do
  #     member do
  #       get 'short'
  #       post 'toggle'
  #     end
  #
  #     collection do
  #       get 'sold'
  #     end
  #   end

  # Sample resource route with sub-resources:
  #   resources :products do
  #     resources :comments, :sales
  #     resource :seller
  #   end

  # Sample resource route with more complex sub-resources
  #   resources :products do
  #     resources :comments
  #     resources :sales do
  #       get 'recent', :on => :collection
  #     end
  #   end

  # Sample resource route within a namespace:
  #   namespace :admin do
  #     # Directs /admin/products/* to Admin::ProductsController
  #     # (app/controllers/admin/products_controller.rb)
  #     resources :products
  #   end

  # You can have the root of your site routed with "root"
  # just remember to delete public/index.html.
  # root :to => 'welcome#index'

  # See how all your routes lay out with "rake routes"

  # This is a legacy wild controller route that's not recommended for RESTful applications.
  # Note: This route will make all actions in every controller accessible via GET requests.
  # match ':controller(/:action(/:id))(.:format)'
end
