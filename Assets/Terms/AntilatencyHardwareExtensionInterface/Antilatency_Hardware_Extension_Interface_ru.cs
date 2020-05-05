﻿using Csml;

partial class Terms : Scope {
    static Material Antilatency_Hardware_Extension_Interface_ru => new Material(null, null,
    $"Реализаци доступа к GPIO сокета через UsbTypeC разъём с помощью {Hardware.ExtensionBoard} и {Software.Antilatency_Hardware_Extension_Interface_Library}")
        [new Section("Поддерживаемые сокеты")
            [new UnorderedList()
                [$"*{Hardware.SocketUsbRadio}*(hardware version 2.0.0) - режим UsbRadioSocket и RadioSocket."]]]

        [new Section("Подключение")
            [$"Используется {Hardware.ExtensionBoard} 2.0.0."]
            [Antilatency_Hardware_Extension_Interface_Assets.Connection]]

        [new UnorderedList()
            [$"Сокет подключается к {Hardware.ExtensionBoard} при помощи Usb 3.1 Type-C кабеля(важно именно 3.1, так как нужны все 4 дифф. пары в кабели). Подключить необходимо одинаковой ориентацией коннекторов для того, чтобы соединить сокет и плату расширения один к одному без перекрещивания сигнальных линий. Существуют кабели, внутри которых, уже есть перекрещивание, такие необходимо подключать наоборот - разной ориентацией."]
            [$"Питание подключается к {Hardware.ExtensionBoard} с помощью любого Type-C кабеля."]]

        [new Info()[$"{Hardware.ExtensionBoard} не симметрична, то есть подключать нужно с правильной стороны(как на схеме). Синие коннекторы стоят со стороны разъема для питания."]]
    ;   


}