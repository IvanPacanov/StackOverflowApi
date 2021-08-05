using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Entities.GitTag;

namespace TestTask.Model.AdapterGit.Tags
{
    public class ExampleData
    {
       public static Root root1 = new Root()
        {

            items = new List<Item>() {
     new Item()
     {
         has_synonyms = true,
         is_moderator_only = false,
         is_required = false,
         count = 2252546,
         name = "javascript"
     },
            new Item()
            {
                has_synonyms = true,
                is_moderator_only = false,
                is_required = false,
                count = 1791332,
                name = "java"
            },
            new Item()
            {
                has_synonyms = true,
                is_moderator_only = false,
                is_required = false,
                count = 1771451,
                name = "python"
            },
            new Item()
            {
                collectives = new List<Collective>() { new Collective()
        {
           tags = new List<string>() {
            "c#",
            "audio"
           },
         external_links = new List<ExternalLink>() {
             new ExternalLink() {
              type = "website",
              link = "https://example.com"
            },
             new ExternalLink() {
              type = "support",
              link = "mailto:support@example.com"
            },
             new ExternalLink() {
              type = "twitter",
              link = "https://twitter.com/stackoverflow"
            },
             new ExternalLink() {
              type = "github",
              link = "https://github.com/stackoverflow"
            },
             new ExternalLink() {
              type = "facebook",
              link = "https://facebook.com/stackoverflow"
            },
             new ExternalLink() {
              type = "instagram",
              link = "https://instagram.com/stackoverflow"
            }
         },
          description = "Official Q&amp;A support for AudioBubble",
          link = "/collectives/audiobubble",
          name = "AudioBubble",
          slug = "audiobubble"
        }
      },
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 1491587,
      name = "c#"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 1410837,
      name = "php"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 1343969,
      name = "android"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 1083973,
      name = "html"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 1015675,
      name = "jquery"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 733381,
      name = "c++"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 727111,
      name = "css"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 659270,
      name = "ios"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 629570,
      name = "mysql"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 599875,
      name = "sql"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 413694,
      name = "r"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 396957,
      name = "node.js"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 369459,
      name = "arrays"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 364012,
      name = "asp.net"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 362729,
      name = "c"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 327467,
      name = "ruby-on-rails"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 323248,
      name = "json"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 322389,
      name = "reactjs"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 310065,
      name = ".net"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 307317,
      name = "sql-server"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 300068,
      name = "swift"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 291873,
      name = "objective-c"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 291324,
      name = "python-3.x"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 272181,
      name = "django"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 262249,
      name = "angularjs"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 258848,
      name = "angular"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 249556,
      name = "excel"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 242689,
      name = "regex"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 221164,
      name = "iphone"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 220385,
      name = "ruby"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 216771,
      name = "ajax"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 210762,
      name = "pandas"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 207183,
      name = "linux"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 203450,
      name = "xml"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 195258,
      name = "asp.net-mvc"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 190388,
      name = "vba"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 187375,
      name = "spring"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 180654,
      name = "database"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 178625,
      name = "wordpress"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 178545,
      name = "laravel"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 167090,
      name = "string"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 162380,
      name = "wpf"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 155735,
      name = "typescript"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 151492,
      name = "windows"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 151218,
      name = "mongodb"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 151144,
      name = "xcode"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 140832,
      name = "postgresql"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 137151,
      name = "bash"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 135737,
      name = "oracle"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 135466,
      name = "git"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 134807,
      name = "vb.net"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 130720,
      name = "multithreading"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 122551,
      name = "eclipse"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 121090,
      name = "amazon-web-services"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 119572,
      name = "list"
    },
     new Item() {
     collectives = new List<Collective>() { new Collective()
         {
           tags = new List<string>()  {
            "google-cloud-internal-load-balancer",
            "google-cloud-url-maps",
            "google-container-builder",
            "google-anthos",
            "google-cloud-speech",
            "google-cloud-vision",
            "google-cloud-tasks",
            "apigee",
            "google-cloud-automl-nl",
            "google-cloud-vpn",
            "google-cloud-stackdriver",
            "google-cloud-monitoring",
            "google-cloud-powershell",
            "google-cloud-pubsublite",
            "google-cloud-healthcare",
            "google-cloud-php-client",
            "google-cloud-spanner",
            "google-bigquery",
            "google-cloud-dataproc",
            "google-cloud-dataflow",
            "google-cloud-network-load-balancer",
            "google-app-engine-launch",
            "google-app-engine-deploy",
            "google-cloud-pubsub-emulator",
            "google-cloud-composer",
            "google-cloud-data-fusion",
            "google-cloud-console",
            "jib-maven-plugin",
            "google-cloud-messaging",
            "google-compute-engine",
            "google-cloud-sql",
            "google-cloud-nl",
            "google-cloud-filestore",
            "google-cloud-repository",
            "google-cloud-http-load-balancer",
            "google-cloud-armor",
            "google-cloud-tools",
            "google-container-registry",
            "google-cloud-billing",
            "google-cloud-spanner-emulator",
            "google-cloud-ml",
            "google-cloud-automl",
            "google-cloud-node",
            "google-cloud-storage",
            "google-cloud-router",
            "google-cloud-iot",
            "google-cloud-dataprep",
            "google-cloud-webrisk",
            "google-cloud-endpoints-v2",
            "google-cloud-asset-inventory",
            "google-cloud-resource-manager",
            "google-cloud-instance-template",
            "google-cloud-save",
            "google-cloud-print-privet",
            "google-cloud-recommendation",
            "google-cloud-datalab",
            "google-cloud-dns",
            "google-cloud-marketplace",
            "google-cloud-identity-aware-proxy",
            "google-cloud-source-repos",
            "dialogflow-cx",
            "google-cloud-intellij",
            "google-cloud-networking",
            "google-cloud-proxy",
            "google-cloud-talent-solution",
            "firebase",
            "jib",
            "google-cloud-sdk",
            "google-app-engine-php",
            "google-cloud-run",
            "google-kubernetes-engine",
            "google-cloud-cdn",
            "google-app-engine-golang",
            "google-container-os",
            "google-cloud-language",
            "google-cloud-memorystore",
            "google-app-engine",
            "google-cloud-ai-platform-pipelines",
            "google-cloud-debugger",
            "google-cloud-shell",
            "google-app-engine-python",
            "google-cloud-data-transfer",
            "google-cloud-build",
            "google-cloud-logging",
            "google-cloud-ai",
            "google-cloud-search",
            "google-migrate-for-compute-engine",
            "dialogflow-es",
            "google-cloud-api-gateway",
            "google-cloud-dlp",
            "google-cloud-speech-boost",
            "google-cloud-storage-r",
            "google-cloud-visualstudio",
            "google-data-studio",
            "google-dataflow",
            "google-cloud-shell-editor",
            "google-cloud-ml-engine",
            "google-cloud-pubsub",
            "firebase-realtime-database",
            "google-cloud-trace",
            "google-analytics-firebase",
            "google-cloud-identity",
            "google-cloud-error-reporting",
            "google-cloud-metrics",
            "maven-jib",
            "google-cloud-profiler",
            "gcloud",
            "google-container-optimized-os",
            "google-prediction",
            "google-cloud-load-balancer",
            "google-cloud-registry",
            "google-cloud-cpp",
            "google-cloud-test-lab",
            "google-cloud-launcher",
            "google-cloud-translate",
            "google-cloud-code",
            "google-cloud-scheduler",
            "google-cloud-iam",
            "google-cloud-firestore",
            "google-cloud-interconnect",
            "google-cloud-tpu",
            "google-cloud-kms",
            "google-cloud-functions",
            "google-cloud-platform",
            "google-cloud-robotics",
            "google-cloud-python",
            "dialogflow-es-fulfillment",
            "google-cloud-print",
            "google-fusion-tables",
            "google-cloud-datastore",
            "google-app-engine-patch",
            "google-app-engine-go",
            "apigee-baas",
            "google-cloud-bigtable",
            "google-cloud-endpoints",
            "bigtable"
          },
         external_links = new List<ExternalLink>(){
             new ExternalLink() {
              type = "website",
              link = "https://cloud.google.com/developers"
            },
             new ExternalLink() {
              type = "support",
              link = "https://googlecloud-community.slack.com/"
            },
             new ExternalLink() {
              type = "twitter",
              link = "https://twitter.com/googlecloudtech"
            },
             new ExternalLink() {
              type = "facebook",
              link = "https://facebook.com/googlecloud"
            },
             new ExternalLink() {
              type = "instagram",
              link = "https://instagram.com/googlecloud"
            }
          },
          description = "Google Cloud provides organizations with leading infrastructure, platform capabilities and industry solutions to help them solve their most critical business problems.",
          link = "/collectives/google-cloud",
          name = "Google Cloud",
          slug = "google-cloud"
        }
      },
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 115723,
      name = "firebase"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 109083,
      name = "algorithm"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 108497,
      name = "macos"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 108486,
      name = "spring-boot"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 107434,
      name = "forms"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 107268,
      name = "azure"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 106355,
      name = "image"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 105168,
      name = "scala"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 104035,
      name = "visual-studio"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 103491,
      name = "react-native"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 101114,
      name = "twitter-bootstrap"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 101114,
      name = "docker"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 100188,
      name = "dataframe"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 96480,
      name = "flutter"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 96211,
      name = "function"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 94771,
      name = "python-2.7"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 94638,
      name = "powershell"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 94193,
      name = "performance"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 93225,
      name = "api"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 93160,
      name = "winforms"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 92679,
      name = "numpy"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 91316,
      name = "matlab"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 89655,
      name = "apache"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 88935,
      name = "sqlite"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 88797,
      name = "selenium"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 88162,
      name = "hibernate"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 87033,
      name = "entity-framework"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 85348,
      name = "facebook"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 83787,
      name = "rest"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 83731,
      name = "shell"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 83243,
      name = "loops"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 82006,
      name = "vue.js"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 81811,
      name = "linq"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 80106,
      name = "maven"
    },
     new Item() {
      has_synonyms = false,
      is_moderator_only = false,
      is_required = false,
      count = 79870,
      name = "qt"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 79714,
      name = "android-studio"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 78752,
      name = "csv"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 78612,
      name = "express"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 78603,
      name = "swing"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 76146,
      name = "unit-testing"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 75438,
      name = "file"
    },
     new Item() {
      has_synonyms = true,
      is_moderator_only = false,
      is_required = false,
      count = 71994,
      name = "class"
     }
            },
            has_more = true,
            quota_max = 10000,
            quota_remaining = 9686


        };
        public static Root root2 = new Root()
        {
            items = new List<Item>()
            {
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 70354,
                    name = ".htaccess"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 69774,
                    name = "apache-spark"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 69426,
                    name = "symfony"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 68692,
                    name = "date"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 68670,
                    name = "sorting"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 68413,
                    name = "codeigniter"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 67726,
                    name = "tsql"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 67596,
                    name = "google-chrome"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 65781,
                    name = "perl"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 64680,
                    name = "dictionary"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 64230,
                    name = "google-maps"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 63897,
                    name = "opencv"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 63424,
                    name = "uitableview"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 62957,
                    name = "validation"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 62714,
                    name = "sockets"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 62518,
                    name = "http"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 62001,
                    name = "asp.net-core"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 61805,
                    name = "datetime"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 61206,
                    name = "cordova"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 60794,
                    name = "kotlin"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 60389,
                    name = "for-loop"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 60139,
                    name = "web-services"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 59822,
                    name = "matplotlib"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 59015,
                    name = "unity3d"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 58584,
                    name = "xaml"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 57641,
                    name = "android-layout"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 57546,
                    name = "object"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 56668,
                    name = "oop"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 56531,
                    name = "email"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 56102,
                    name = "spring-mvc"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 56025,
                    name = "ruby-on-rails-3"
                },
                new Item()
                {
                    collectives = new List<Collective>()
                    {
                        new Collective()
                        {
                            tags = new List<string>()
                            {
                                "go-guru",
                                "go-fiber",
                                "go-cdk",
                                "go-cmp",
                                "go-iris",
                                "go-interface",
                                "go-server",
                                "go-github",
                                "go-couchbase",
                                "go-gl",
                                "goroutine",
                                "golang-migrate",
                                "go-swagger",
                                "go-font",
                                "go-toolchain",
                                "go-structtag",
                                "mgo",
                                "go-gtk",
                                "go-playground",
                                "go-get",
                                "go-restful",
                                "go-present",
                                "go-reflect",
                                "go-chart",
                                "go-echo",
                                "go-alice",
                                "go-git",
                                "go-templates",
                                "go-micro",
                                "cgo",
                                "go-jennifer",
                                "go-testing",
                                "google-app-engine-golang",
                                "go-generate",
                                "go-flag",
                                "go-2",
                                "go-sqlite3",
                                "go-imagick",
                                "go-chi",
                                "go-ethereum",
                                "go-pg",
                                "go-xorm",
                                "go-cobra",
                                "go-html-template",
                                "glide-golang",
                                "go",
                                "go-nsq",
                                "go-sqlmock",
                                "go-redis",
                                "gccgo",
                                "go-modules",
                                "go-context",
                                "go-map",
                                "go-colly",
                                "go-packages",
                                "go-gorm",
                                "go-scheduler",
                                "go-graceful",
                                "go-bundle",
                                "go-libp2p",
                                "go-http",
                                "go-gin",
                                "go-list",
                                "go-agent",
                                "go-build",
                                "go-guardian"
                            },
                            external_links = new List<ExternalLink>()
                            {
                                new ExternalLink()
                                {
                                    type = "website",
                                    link = "https://go.dev/"
                                },
                                new ExternalLink()
                                {
                                    type = "support",
                                    link = "mailto:stackoverflow@golang.org"
                                },
                                new ExternalLink()
                                {
                                    type = "twitter",
                                    link = "https://twitter.com/golang"
                                },
                                new ExternalLink()
                                {
                                    type = "github",
                                    link = "https://github.com/golang"
                                }
                            },
                            description = "The official Q&A channel for Google's Go Programming Language",
                            link = "/collectives/go",
                            name = "Go Language",
                            slug = "go"
                        }
                    },
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 55251,
                    name = "go"
                },

                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 54948,
                    name = "dart"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 54424,
                    name = "ubuntu"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 54159,
                    name = "c++11"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 53871,
                    name = "ms-access"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 53792,
                    name = "sql-server-2008"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 53490,
                    name = "if-statement"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 53468,
                    name = "parsing"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 53100,
                    name = "security"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 52416,
                    name = "user-interface"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 51879,
                    name = "jsp"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 51517,
                    name = "pointers"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 51365,
                    name = "listview"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 51354,
                    name = "elasticsearch"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 51286,
                    name = "authentication"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 50766,
                    name = "batch-file"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 50438,
                    name = "wcf"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 50263,
                    name = "templates"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 49489,
                    name = "variables"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 48363,
                    name = "delphi"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 47921,
                    name = "nginx"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 47861,
                    name = "debugging"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 47071,
                    name = "haskell"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 46936,
                    name = "machine-learning"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 46903,
                    name = "visual-studio-2010"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 46701,
                    name = "ssl"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 46695,
                    name = "flask"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 46600,
                    name = "pdf"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 46529,
                    name = "xamarin"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 46455,
                    name = "jpa"
                },

                new Item()
                {
                    collectives = new List<Collective>()
                    {
                        new Collective()
                        {
                            tags = new List<string>()
                            {
                                "google-cloud-cpp",
                                "google-cloud-cdn",
                                "google-cloud-billing",
                                "dialogflow-es",
                                "google-container-registry",
                                "google-container-optimized-os",
                                "google-cloud-tools",
                                "jib-maven-plugin",
                                "google-cloud-shell",
                                "google-cloud-run",
                                "google-cloud-identity",
                                "google-cloud-internal-load-balancer",
                                "firebase-realtime-database",
                                "google-cloud-speech",
                                "google-cloud-recommendation",
                                "google-cloud-nl",
                                "google-cloud-talent-solution",
                                "google-cloud-armor",
                                "google-cloud-scheduler",
                                "google-cloud-build",
                                "google-bigquery",
                                "google-cloud-code",
                                "google-app-engine-patch",
                                "apigee",
                                "google-app-engine-launch",
                                "google-cloud-kms",
                                "google-cloud-load-balancer",
                                "google-cloud-robotics",
                                "google-cloud-webrisk",
                                "google-cloud-memorystore",
                                "google-cloud-api-gateway",
                                "google-cloud-console",
                                "google-cloud-iot",
                                "google-cloud-pubsublite",
                                "google-cloud-resource-manager",
                                "gcloud",
                                "google-cloud-repository",
                                "google-app-engine",
                                "google-cloud-ml",
                                "google-prediction",
                                "google-cloud-healthcare",
                                "google-cloud-print",
                                "google-cloud-composer",
                                "firebase",
                                "google-cloud-endpoints-v2",
                                "dialogflow-es-fulfillment",
                                "google-app-engine-php",
                                "dialogflow-cx",
                                "google-cloud-datalab",
                                "google-container-os",
                                "google-cloud-datastore",
                                "google-cloud-functions",
                                "google-cloud-dataprep",
                                "google-cloud-launcher",
                                "google-fusion-tables",
                                "google-cloud-endpoints",
                                "google-cloud-iam",
                                "google-anthos",
                                "google-cloud-url-maps",
                                "google-cloud-sql",
                                "google-cloud-data-fusion",
                                "google-cloud-automl-nl",
                                "google-cloud-tpu",
                                "google-cloud-test-lab",
                                "google-cloud-php-client",
                                "google-app-engine-golang",
                                "google-cloud-registry",
                                "google-cloud-node",
                                "google-cloud-network-load-balancer",
                                "google-cloud-instance-template",
                                "google-cloud-translate",
                                "google-cloud-sdk",
                                "google-cloud-messaging",
                                "google-cloud-intellij",
                                "google-cloud-pubsub-emulator",
                                "google-cloud-http-load-balancer",
                                "google-cloud-monitoring",
                                "google-kubernetes-engine",
                                "google-cloud-storage-r",
                                "google-cloud-print-privet",
                                "google-cloud-save",
                                "google-compute-engine",
                                "google-cloud-identity-aware-proxy",
                                "google-cloud-pubsub",
                                "bigtable",
                                "google-cloud-trace",
                                "google-migrate-for-compute-engine",
                                "google-cloud-logging",
                                "google-analytics-firebase",
                                "google-cloud-stackdriver",
                                "google-app-engine-python",
                                "google-cloud-speech-boost",
                                "maven-jib",
                                "google-cloud-proxy",
                                "google-dataflow",
                                "google-cloud-shell-editor",
                                "apigee-baas",
                                "google-cloud-filestore",
                                "google-cloud-tasks",
                                "google-cloud-data-transfer",
                                "google-cloud-search",
                                "google-cloud-dns",
                                "google-cloud-storage",
                                "google-cloud-metrics",
                                "google-cloud-dataflow",
                                "google-cloud-interconnect",
                                "google-cloud-debugger",
                                "google-cloud-ai-platform-pipelines",
                                "google-cloud-powershell",
                                "google-container-builder",
                                "google-cloud-spanner-emulator",
                                "google-cloud-automl",
                                "google-cloud-profiler",
                                "google-cloud-error-reporting",
                                "google-cloud-vpn",
                                "google-cloud-ml-engine",
                                "google-cloud-asset-inventory",
                                "google-cloud-source-repos",
                                "google-cloud-language",
                                "google-cloud-bigtable",
                                "jib",
                                "google-data-studio",
                                "google-cloud-dataproc",
                                "google-cloud-marketplace",
                                "google-cloud-spanner",
                                "google-app-engine-go",
                                "google-cloud-router",
                                "google-cloud-firestore",
                                "google-cloud-visualstudio",
                                "google-cloud-platform",
                                "google-app-engine-deploy",
                                "google-cloud-ai",
                                "google-cloud-vision",
                                "google-cloud-dlp",
                                "google-cloud-python",
                                "google-cloud-networking"
                            },
                            external_links = new List<ExternalLink>()
                            {
                                new ExternalLink()
                                {
                                    type = "website",
                                    link = "https://cloud.google.com/developers"
                                },
                                new ExternalLink()
                                {
                                    type = "support",
                                    link = "https://googlecloud-community.slack.com/"
                                },
                                new ExternalLink()
                                {
                                    type = "twitter",
                                    link = "https://twitter.com/googlecloudtech"
                                },
                                new ExternalLink()
                                {
                                    type = "facebook",
                                    link = "https://facebook.com/googlecloud"
                                },
                                new ExternalLink()
                                {
                                    type = "instagram",
                                    link = "https://instagram.com/googlecloud"
                                }
                            },
                            description = "Google Cloud provides organizations with leading infrastructure, platform capabilities and industry solutions to help them solve their most critical business problems.",
                            link = "/collectives/google-cloud",
                            name = "Google Cloud",
                            slug = "google-cloud"
                        }
                    },
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 46037,
                    name = "google-app-engine"
                },

                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 45566,
                    name = "github"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 45444,
                    name = "unix"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 45442,
                    name = "asynchronous"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 45369,
                    name = "jenkins"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 44586,
                    name = "android-fragments"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 44350,
                    name = "selenium-webdriver"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 44316,
                    name = "generics"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 43882,
                    name = "testing"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 43842,
                    name = "web"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 43685,
                    name = "gradle"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 43380,
                    name = "hadoop"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 43279,
                    name = "session"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 43146,
                    name = "ionic-framework"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 43005,
                    name = "ggplot2"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 42300,
                    name = "asp.net-mvc-4"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 41825,
                    name = "amazon-s3"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 41422,
                    name = "tomcat"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 41421,
                    name = "recursion"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 41397,
                    name = "animation"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 41337,
                    name = "actionscript-3"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 40989,
                    name = "url"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 40884,
                    name = "google-apps-script"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 40829,
                    name = "tkinter"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 40746,
                    name = "heroku"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 40725,
                    name = "curl"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 40471,
                    name = "kubernetes"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 39852,
                    name = "npm"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 39565,
                    name = "jquery-ui"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 39335,
                    name = "cocoa"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 39219,
                    name = "math"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 39214,
                    name = "exception"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 39124,
                    name = "inheritance"
                },
                new Item()
                {
                    has_synonyms = false,
                    is_moderator_only = false,
                    is_required = false,
                    count = 39082,
                    name = "mongoose"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 39027,
                    name = "internet-explorer"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 38998,
                    name = "svg"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 38867,
                    name = "join"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 38676,
                    name = "winapi"
                },
                new Item()
                {
                    has_synonyms = true,
                    is_moderator_only = false,
                    is_required = false,
                    count = 38555,
                    name = "asp.net-mvc-3"
                }
            },
            has_more = true,
            quota_max = 10000,
            quota_remaining = 9686


        };
    }
}
