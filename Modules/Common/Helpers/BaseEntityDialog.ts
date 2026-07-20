import { EntityDialog } from "@serenity-is/corelib";

export abstract class BaseEntityDialog<TItem, TOptions>
    extends EntityDialog<TItem, TOptions> {

    private escHandler!: (e: KeyboardEvent) => void;

    protected override onDialogOpen() {
        super.onDialogOpen();

        this.escHandler = (e: KeyboardEvent) => {
            if (e.key === "Escape")
                this.dialogClose();
        };

        document.addEventListener("keydown", this.escHandler);
    }

    protected override onDialogClose() {
        document.removeEventListener("keydown", this.escHandler);
        super.onDialogClose();
    }

    protected override getDialogOptions() {
        const opt = super.getDialogOptions();
        opt.size = 'lg'; // 'sm' | 'lg' | 'xl' instead of full width
        opt.preferBSModal = true;
        opt.preferPanel = false;
        opt.closeOnEscape = true;
        return opt;
    }
}
