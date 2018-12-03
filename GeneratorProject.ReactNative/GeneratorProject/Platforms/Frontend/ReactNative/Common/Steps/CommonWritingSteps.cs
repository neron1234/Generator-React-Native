using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Contexts;
using Mobioos.Scaffold.BaseInfrastructure.Notifiers;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using WorkflowCore.Interface;
using WorkflowCore.Models;

using System;
using System.IO;
using System.Threading.Tasks;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    public class CommonWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public CommonWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
        {
            _context = context;
            _writingService = writingService;
            _workflowNotifier = workflowNotifier;
        }

        public override Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            if (null == _context.Manifest)
                throw new ArgumentNullException(nameof(_context.Manifest));

            SmartAppInfo smartApp = _context.Manifest;

            var commonTemplates = "Platforms\\Frontend\\ReactNative\\Common\\Templates";


            _workflowNotifier.Notify(nameof(CommonWritingSteps), NotificationType.GeneralInfo, "Generating ReactNative common files");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
               var commonTemplatesDirectoryPath = Path.Combine(_context.GeneratorPath, commonTemplates);

                TransformStaticFile(smartApp, commonTemplatesDirectoryPath);
                TransferRootFiles(smartApp);
                TransferAndroidFiles(smartApp);
                TransferIosFiles(smartApp);
                TransferIosStaticFiles(smartApp);
            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformStaticFile(SmartAppInfo smartApp, string templatesDirectoryPath)
        {
            if (smartApp != null && templatesDirectoryPath != null)
            {
                _writingService.CopyDirectory(templatesDirectoryPath, _context.BasePath);
            }
        }

        private void TransferRootFiles(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                IndexTemplate indexTemplate = new IndexTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, indexTemplate.OutputPath), indexTemplate.TransformText());

                AppJsonTemplate appJsonTemplate = new AppJsonTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, appJsonTemplate.OutputPath), appJsonTemplate.TransformText());

                PackageJsonTemplate packageJsonTemplate = new PackageJsonTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, packageJsonTemplate.OutputPath), packageJsonTemplate.TransformText());
            }
        }

        private void TransferAndroidFiles(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                AndroidManifestTemplate androidManifestTemplate = new AndroidManifestTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, androidManifestTemplate.OutputPath), androidManifestTemplate.TransformText());

                MainActivityTemplate mainActivityTemplate = new MainActivityTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, mainActivityTemplate.OutputPath), mainActivityTemplate.TransformText());

                MainApplicationTemplate mainApplicationTemplate = new MainApplicationTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, mainApplicationTemplate.OutputPath), mainApplicationTemplate.TransformText());

                ProjectTemplate projectTemplate = new ProjectTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, projectTemplate.OutputPath), projectTemplate.TransformText());

                SettingsTemplate settingsTemplate = new SettingsTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, settingsTemplate.OutputPath), settingsTemplate.TransformText());

                StringsTemplate stringsTemplate = new StringsTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, stringsTemplate.OutputPath), stringsTemplate.TransformText());
            }
        }

        private void TransferIosFiles(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                AppDelegateTemplate appDelegateTemplate = new AppDelegateTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, appDelegateTemplate.OutputPath), appDelegateTemplate.TransformText());

                InfoTemplate infoTemplate = new InfoTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, infoTemplate.OutputPath), infoTemplate.TransformText());

                LaunchScreenTemplate launchScreenTemplate = new LaunchScreenTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, launchScreenTemplate.OutputPath), launchScreenTemplate.TransformText());

                ProjectPbxprojTemplate projectPbxprojTemplate = new ProjectPbxprojTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, projectPbxprojTemplate.OutputPath), projectPbxprojTemplate.TransformText());

                SampleTemplate sampleTemplate = new SampleTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, sampleTemplate.OutputPath), sampleTemplate.TransformText());

                SampleTestsTemplate sampleTestsTemplate = new SampleTestsTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, sampleTestsTemplate.OutputPath), sampleTestsTemplate.TransformText());

                SampleTvOSTemplate sampleTvOSTemplate = new SampleTvOSTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, sampleTvOSTemplate.OutputPath), sampleTvOSTemplate.TransformText());
            }
        }

        private void TransferIosStaticFiles(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                InfoPlistTvOSTestsTemplate infoPlistTvOSTestsTemplate = new InfoPlistTvOSTestsTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, infoPlistTvOSTestsTemplate.OutputPath), infoPlistTvOSTestsTemplate.TransformText());

                InfoPlistTvOSTemplate infoPlistTvOSTemplate = new InfoPlistTvOSTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, infoPlistTvOSTemplate.OutputPath), infoPlistTvOSTemplate.TransformText());

                InfoPlistTestsTemplate infoPlistTestsTemplate = new InfoPlistTestsTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, infoPlistTestsTemplate.OutputPath), infoPlistTestsTemplate.TransformText());

                AppDelegateHTemplate appDelegateHTemplate = new AppDelegateHTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, appDelegateHTemplate.OutputPath), appDelegateHTemplate.TransformText());

                MainTemplate mainTemplate = new MainTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, mainTemplate.OutputPath), mainTemplate.TransformText());

                ContentsTemplate contentsTemplate = new ContentsTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, contentsTemplate.OutputPath), contentsTemplate.TransformText());

                ContentsAppIconTemplate contentsAppIconTemplate = new ContentsAppIconTemplate(smartApp);
                _writingService.WriteFile(Path.Combine(_context.BasePath, contentsAppIconTemplate.OutputPath), contentsAppIconTemplate.TransformText());
            }
        }

    }
}
