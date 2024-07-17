import random

tipo_especies = ["Zorro", "Perro", "Pulpo"]
gafas = ["Gafas de sol", "Gafas de lectura", "Sin gafas", "Gafas fiesteras"]
sombreros = ["Sombrero de paja", "Gorra", "Sin sombrero", "Boina", "Sombrero vaquero", "Deportiva"]
colores_pelaje = ["Pelaje marrón", "Pelaje negro", "Pelaje blanco", "Pelaje gris", "Pelaje manchado", "Pelaje tricolor"]
tamanos = ["Tamaño pequeño", "Tamaño mediano", "Tamaño grande"]
pesos = ["Peso ligero", "Peso medio", "Peso pesado"]
razas = ["Raza 1", "Raza 2", "Raza 3"]
joyas = ["Collar de diamantes", "Pulsera de oro", "Sin joyas", "Reloj"]
colores_ojos = ["Ojos azul", "Ojos verde", "Ojos marrones", "Ojos negros", "Ojos dorados"]

def lista_de_opciones(lista):
    for i, item in enumerate(lista, 1):
        print(f"{i}. {item}")
    seleccion = input("Introduce el número de tu elección: ")
    if seleccion.isdigit():
        seleccion = int(seleccion)
        if 1 <= seleccion <= len(lista):
            return lista[seleccion - 1]
    print("Por favor, ingresa un número válido de opción.")
    return lista_de_opciones(lista)

def opciones():
    print("Selecciona una opción:")
    print("1. Automático (Generar un animal aleatorio)")
    print("2. Manual (Seleccionar características manualmente)")

def animal_random():
    animal = {
        "Especie": random.choice(tipo_especies),
        "Gafas": random.choice(gafas),
        "Sombrero": random.choice(sombreros),
        "Color de Pelaje": random.choice(colores_pelaje),
        "Tamaño": random.choice(tamanos),
        "Peso": random.choice(pesos),
        "Raza": random.choice(razas),
        "Joyas": random.choice(joyas),
        "Color de Ojos": random.choice(colores_ojos),
    }
    return animal

def generar_animal_manual():
    print("Selecciona las características del animal:")
    especie = lista_de_opciones(tipo_especies)
    gafas_seleccion = lista_de_opciones(gafas)
    sombrero_seleccion = lista_de_opciones(sombreros)
    color_pelaje = lista_de_opciones(colores_pelaje)
    tamano_seleccion = lista_de_opciones(tamanos)
    peso_seleccion = lista_de_opciones(pesos)
    raza_seleccion = lista_de_opciones(razas)
    joyas_seleccion = lista_de_opciones(joyas)
    color_ojos = lista_de_opciones(colores_ojos)
    
    animal = {
        "Especie": especie,
        "Gafas": gafas_seleccion,
        "Sombrero": sombrero_seleccion,
        "Color de Pelaje": color_pelaje,
        "Tamaño": tamano_seleccion,
        "Peso": peso_seleccion,
        "Raza": raza_seleccion,
        "Joyas": joyas_seleccion,
        "Color de Ojos": color_ojos,
    }
    return animal

def mostrar_animal(animal):
    print("\nCaracterísticas del animal:")
    for key, value in animal.items():
        print(f"{key}: {value}")

def main():
    opciones()
    opcion = input("Introduce el número de tu elección (1-2): ")
    
    if opcion == "1":
        animal = animal_random()
    elif opcion == "2":
        animal = generar_animal_manual()
    else:
        print("Opción no válida. Generando un animal aleatorio.")
        animal = animal_random()
    
    mostrar_animal(animal)

if __name__ == "__main__":
    main()