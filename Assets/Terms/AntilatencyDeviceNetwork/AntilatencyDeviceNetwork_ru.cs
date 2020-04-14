﻿using Csml;
partial class Root {
    static Material Antilatency_Device_Network_ru => new Material(null, null,
    $"Библиотека для комуникации с устройствами Antilatency. Позволяет находить устройства среди подключенных, отслеживать подключение новых устройств, запускать задачи на устройствах, а также обновлять прошивку.")
        [new Section("Инициализация")
            [$"Для начала работы с {Antilatency_Device_Network} нужно загрузить библиотеку и создать экземпляр `ILibrary`"]
        ]
        [new Section("Nodes")
            [@$"При подключении к сети каждое устройство получает идентификатор `NodeHandle`.
                Идентификаторы не повторяются в процессе работы одного экземпляра сети.
                
            "]
        ]
        [FirmwareUpdateWarning]
    ;
    


}