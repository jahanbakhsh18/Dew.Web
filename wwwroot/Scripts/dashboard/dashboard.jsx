
class RootComponent extends React.Component {

    constructor() {
        super();
        this.state = { value: [] };
    }

    async getData() {

        function getCookie(name) {
            if (!document.cookie) {
                return null;
            }

            const xsrfCookies = document.cookie.split(';')
                .map(c => c.trim())
                .filter(c => c.startsWith(name + '='));

            if (xsrfCookies.length === 0) {
                return null;
            }
            return decodeURIComponent(xsrfCookies[0].split('=')[1]);
        }

        /*let resp = await fetch('/Services/BaseData/PaymentMethods/List',
            {
                method: "POST",
                credentials: 'include',
                headers: { 'Content-Type': 'application/json', 'X-CSRF-Token': getCookie('CSRF-TOKEN') },
                body: JSON.stringify({ "IncludeColumns": ["Id", "Method"], "Sort": ["Id"], "Take": 100 })
            });*/

        let resp = await fetch('Dashboard/GetDashboardStatistics',
            {
                method: "GET",
                credentials: 'include',
                headers: { 'Content-Type': 'application/json', 'X-CSRF-Token': getCookie('CSRF-TOKEN') }
            });

        if (resp.status === 200) {
            let value = await resp.json();
            return value;
        }
    }

    async componentDidMount() {
        let value = await this.getData();
        this.setState({ value: value });
    }

    render() {

        if (this.state.value.length == 0)
            return;

        return <div className="row">
            <DashboardCard text="Open Orders" count={`${this.state.value.OpenOrders}`} color="bg-primary" icon="fa-shopping-cart" />
            <DashboardCard text="Closed Orders (%)" count={`${this.state.value.ClosedOrderPercent}`} color="bg-info" icon="fa-truck" />
            <DashboardCard text="Total Customers" count={`${this.state.value.CustomerCount}`} color="bg-warning" icon="fa-user-plus" />
            <DashboardCard text="Product Types" count={`${this.state.value.ProductCount}`} color="bg-success" icon="fa-tag" />
        </div>;
    }
}

class DashboardCard extends React.Component {
    render() {
        return (
            <div className="col-lg-3 col-sm-6">
                <div className={`card s-dashboard-card-sm bg-opacity-50 ${this.props.color}`}>
                    <div className="card-body">
                        <h3>{this.props.count}</h3>
                        <p>{this.props.text}</p>
                    </div>
                    <div className="icon">
                        <i className={`fa ${this.props.icon}`}></i>
                    </div>
                </div>
            </div>
        );
    }
}

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(React.createElement(RootComponent));

/* <div class="row">
    <div class="col-lg-3 col-sm-6">
        <div class="card s-dashboard-card-sm bg-primary bg-opacity-50">
            <div class="card-body">
                <h3>@Model.OpenOrders</h3>
                <p>Open Orders</p>
            </div>
            <div class="icon">
                <i class="fa fa-shopping-cart"></i>
            </div>
        </div>
    </div>
    <div class="col-lg-3 col-sm-6">
        <div class="card s-dashboard-card-sm s-alt bg-info bg-opacity-50">
            <div class="card-body">
                <h3>@Model.ClosedOrderPercent<sup style="font-size: 20px">%</sup></h3>
                <p>Closed Orders</p>
            </div>
            <div class="icon">
                <i class="fa fa-truck"></i>
            </div>
        </div>
    </div>
    <div class="col-lg-3 col-sm-6">
        <div class="card s-dashboard-card-sm bg-warning bg-opacity-50">
            <div class="card-body">
                <h3>@Model.CustomerCount</h3>
                <p>Total Customers</p>
            </div>
            <div class="icon">
                <i class="fa fa-user-plus"></i>
            </div>
        </div>
    </div>
    <div class="col-lg-3 col-sm-6">
        <div class="card s-dashboard-card-sm s-alt bg-success bg-opacity-50">
            <div class="card-body">
                <h3>@Model.ProductCount</h3>
                <p>Product Types</p>
            </div>
            <div class="icon">
                <i class="fa fa-tag"></i>
            </div>
        </div>
    </div>
</div> */