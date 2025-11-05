# EventEase
EventEase is a fictional company specializing in corporate and social event management

🏗️Project Setup
Helped you scaffold the project structure (folders, files, namespaces).
Generated a clean .csproj with the right NuGet packages for Blazor WebAssembly.
Guided you through Program.cs, App.razor, and Imports.razor so routing and services were wired up correctly.

📦 Models & Services
Created models (EventModel, RegistrationModel, AttendanceRecord) with validation attributes.
Built services (SessionState, AttendanceService) to handle registration state and attendance tracking.

🎨 UI Components & Pages
Designed the EventCard component for reusable event display.
Generated all pages (EventList, EventDetails, EventRegistration, AttendanceTracker, NotFound) with correct routes and logic.
Added Shared layout (MainLayout, NavMenu) for consistent navigation.

🖌️ Styling & Assets
Provided a site.css with clean styling for buttons, tables, cards, and layout.
Set up index.html to bootstrap the Blazor app.

🐞 Debugging & Fixes
Helped resolve NuGet restore errors (invalid package reference).
Fixed binding issues (@bind-Value vs @bind-value).
Corrected router syntax (RouteData="routeData").
Fixed NavLink href errors by switching to string interpolation.
Added a default route so the app doesn’t land on 404 at startup.

🚀 Final Outcome
You now have a fully working Blazor WebAssembly app:
Event list with virtualization
Event details with navigation
Registration form with validation
Attendance tracker with check-in
Shared layout and navigation
Default route landing page
