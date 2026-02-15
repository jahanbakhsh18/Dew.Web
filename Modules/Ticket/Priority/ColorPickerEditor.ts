﻿import { Widget, ISetEditValue, IGetEditValue, Formatter, formatterTypeInfo, registerType } from '@serenity-is/corelib';
import { FormatterContext } from "@serenity-is/sleekgrid";
import { nsTicket } from '../../ServerTypes/Namespaces';

export class TimeFlagFormatter implements Formatter {
    static [Symbol.typeInfo] = formatterTypeInfo(nsTicket); static { registerType(this); }

    format(ctx: FormatterContext) {
        const icon = document.createElement("i");
        icon.className = "fa fa-flag";
        icon.style.color = ctx.value;

        return icon;
    }
}

export class PriorityFormatter implements Formatter {
    static [Symbol.typeInfo] = formatterTypeInfo(nsTicket); static { registerType(this); }

    format(ctx: FormatterContext) {
        const icon = document.createElement("i");
        icon.className = "fa fa-circle";
        icon.style.color = ctx.value;

        return icon;
    }
}

export class ColorPickerEditor extends Widget<any>
    implements IGetEditValue, ISetEditValue {

    static override[Symbol.typeInfo] = this.registerEditor(nsTicket, [IGetEditValue, ISetEditValue]);

    private input!: HTMLInputElement;
    private _value: string = "#ffffff";

    constructor(container: any) {
        super(container);  
        this.updateElementContent();
    }

    private updateElementContent() {

        // Create color input (native browser picker)
        this.input = document.createElement("input");
        this.input.type = "color";
        this.input.className = "editor flexify";
        this.input.id = this.uniqueName;        
        this.input.value = "#ffffff";
        this.element.append(this.input);

        this.input.addEventListener("input", () => {
            this._value = this.input.value;
        });
    }

    public get value(): string {        
        return this._value;
    }

    public set value(color: string) {
        this._value = color;
        if (this.input) {            
            this.input.value = color;
        }
    }

    public getEditValue(property, target) {
        target[property.name] = this.value;
    }

    public setEditValue(source, property) {        
        this.value = source[property.name];
    }
}