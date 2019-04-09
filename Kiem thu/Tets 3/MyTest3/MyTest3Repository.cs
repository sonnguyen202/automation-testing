﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest3
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest3Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("18a28301-0cf6-4749-b11b-83f7899b6aee")]
    public partial class MyTest3Repository : RepoGenBaseFolder
    {
        static MyTest3Repository instance = new MyTest3Repository();
        MyTest3RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        MyTest3RepositoryFolders.FacebookGoogleChromeAppFolder _facebookgooglechrome;
        MyTest3RepositoryFolders.HọcLiệuSachMềmAppFolder _họcliệusachmềm;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest3Repository element repository.
        /// </summary>
        [RepositoryFolder("18a28301-0cf6-4749-b11b-83f7899b6aee")]
        public static MyTest3Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest3Repository() 
            : base("MyTest3Repository", "/", null, 0, false, "18a28301-0cf6-4749-b11b-83f7899b6aee", ".\\RepositoryImages\\MyTest3Repository18a28301.rximgres")
        {
            _applicationundertest = new MyTest3RepositoryFolders.ApplicationUnderTestAppFolder(this);
            _facebookgooglechrome = new MyTest3RepositoryFolders.FacebookGoogleChromeAppFolder(this);
            _họcliệusachmềm = new MyTest3RepositoryFolders.HọcLiệuSachMềmAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("18a28301-0cf6-4749-b11b-83f7899b6aee")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("c18a9fd9-6b18-49e3-b486-56f8d5b718a8")]
        public virtual MyTest3RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The FacebookGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("edd623dd-4e4a-4bdb-8651-18890eb26fba")]
        public virtual MyTest3RepositoryFolders.FacebookGoogleChromeAppFolder FacebookGoogleChrome
        {
            get { return _facebookgooglechrome; }
        }

        /// <summary>
        /// The HọcLiệuSachMềm folder.
        /// </summary>
        [RepositoryFolder("14337e06-cc23-46c5-b8c5-a90233924ce2")]
        public virtual MyTest3RepositoryFolders.HọcLiệuSachMềmAppFolder HọcLiệuSachMềm
        {
            get { return _họcliệusachmềm; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest3RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("c18a9fd9-6b18-49e3-b486-56f8d5b718a8")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, true, "c18a9fd9-6b18-49e3-b486-56f8d5b718a8", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c18a9fd9-6b18-49e3-b486-56f8d5b718a8")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c18a9fd9-6b18-49e3-b486-56f8d5b718a8")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The FacebookGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("edd623dd-4e4a-4bdb-8651-18890eb26fba")]
        public partial class FacebookGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _họcliệusachmềmInfo;
            RepoItemInfo _họcliệusachmềm1Info;

            /// <summary>
            /// Creates a new FacebookGoogleChrome  folder.
            /// </summary>
            public FacebookGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FacebookGoogleChrome", "/form[@title='Facebook - Google Chrome']", parentFolder, 30000, null, true, "edd623dd-4e4a-4bdb-8651-18890eb26fba", "")
            {
                _họcliệusachmềmInfo = new RepoItemInfo(this, "HọcLiệuSachMềm", "container[@accessiblename='Facebook - Google Chrome']/container[@accessiblename='Google Chrome']//tabpage[@accessiblename='Học liệu - Sách Mềm']", 30000, null, "318b0462-960c-45ea-9e55-550e311d4562");
                _họcliệusachmềm1Info = new RepoItemInfo(this, "HọcLiệuSachMềm1", "container[@accessiblename~'^Học\\ liệu\\ -\\ Sách\\ Mềm\\ -\\ Goo']/container[@accessiblename='Google Chrome']//tabpage[@accessiblename='Học liệu - Sách Mềm']", 30000, null, "4917da40-083c-4660-87e3-2bf99cf8bdda");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("edd623dd-4e4a-4bdb-8651-18890eb26fba")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("edd623dd-4e4a-4bdb-8651-18890eb26fba")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The HọcLiệuSachMềm item.
            /// </summary>
            [RepositoryItem("318b0462-960c-45ea-9e55-550e311d4562")]
            public virtual Ranorex.TabPage HọcLiệuSachMềm
            {
                get
                {
                    return _họcliệusachmềmInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The HọcLiệuSachMềm item info.
            /// </summary>
            [RepositoryItemInfo("318b0462-960c-45ea-9e55-550e311d4562")]
            public virtual RepoItemInfo HọcLiệuSachMềmInfo
            {
                get
                {
                    return _họcliệusachmềmInfo;
                }
            }

            /// <summary>
            /// The HọcLiệuSachMềm1 item.
            /// </summary>
            [RepositoryItem("4917da40-083c-4660-87e3-2bf99cf8bdda")]
            public virtual Ranorex.TabPage HọcLiệuSachMềm1
            {
                get
                {
                    return _họcliệusachmềm1Info.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The HọcLiệuSachMềm1 item info.
            /// </summary>
            [RepositoryItemInfo("4917da40-083c-4660-87e3-2bf99cf8bdda")]
            public virtual RepoItemInfo HọcLiệuSachMềm1Info
            {
                get
                {
                    return _họcliệusachmềm1Info;
                }
            }
        }

        /// <summary>
        /// The HọcLiệuSachMềmAppFolder folder.
        /// </summary>
        [RepositoryFolder("14337e06-cc23-46c5-b8c5-a90233924ce2")]
        public partial class HọcLiệuSachMềmAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _submitInfo;
            RepoItemInfo _optiondropdownInfo;
            RepoItemInfo _ataggiaobaitậpInfo;
            RepoItemInfo _đongInfo;

            /// <summary>
            /// Creates a new HọcLiệuSachMềm  folder.
            /// </summary>
            public HọcLiệuSachMềmAppFolder(RepoGenBaseFolder parentFolder) :
                    base("HọcLiệuSachMềm", "/dom[3]", parentFolder, 30000, null, false, "14337e06-cc23-46c5-b8c5-a90233924ce2", "")
            {
                _submitInfo = new RepoItemInfo(this, "Submit", ".//div[#'createAssignmentModal']//form[@action='https://hoclieu.sachmem.vn/folder/Th%C6%B0_m%E1%BB%A5c_c%E1%BB%A7a_t%C3%B4i-5c6d2a760966f254d79b73c9']/?/?/input[@type='submit']", 30000, null, "2a671509-3054-4004-90be-da97e2678199");
                _optiondropdownInfo = new RepoItemInfo(this, "OptionDropdown", "body/tag[@tagname='app-root']/div[2]//ul/li[2]/div/div[2]/span[2]/a[@id='optionDropdown']", 30000, null, "7249d480-75a7-4835-ab22-ba98d3ad3917");
                _ataggiaobaitậpInfo = new RepoItemInfo(this, "ATagGiaoBaiTập", "body/tag[@tagname='app-root']/div[2]//ul/li[2]/div/div[2]/span[2]/?/?/a[@innertext~'^\\ Giao\\ bài\\ tập\\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ ']", 30000, null, "519c3b44-e922-4ab3-bb69-f41d4e157b37");
                _đongInfo = new RepoItemInfo(this, "Đong", ".//div[#'createAssignmentModal']//form[@action='https://hoclieu.sachmem.vn/folder/Th%C6%B0_m%E1%BB%A5c_c%E1%BB%A7a_t%C3%B4i-5c6d2a760966f254d79b73c9']/?/?/button[@innertext='Đóng']", 30000, null, "1ebb85c6-60f2-4854-8fa7-4df3d2ae97ba");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("14337e06-cc23-46c5-b8c5-a90233924ce2")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("14337e06-cc23-46c5-b8c5-a90233924ce2")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Submit item.
            /// </summary>
            [RepositoryItem("2a671509-3054-4004-90be-da97e2678199")]
            public virtual Ranorex.InputTag Submit
            {
                get
                {
                    return _submitInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Submit item info.
            /// </summary>
            [RepositoryItemInfo("2a671509-3054-4004-90be-da97e2678199")]
            public virtual RepoItemInfo SubmitInfo
            {
                get
                {
                    return _submitInfo;
                }
            }

            /// <summary>
            /// The OptionDropdown item.
            /// </summary>
            [RepositoryItem("7249d480-75a7-4835-ab22-ba98d3ad3917")]
            public virtual Ranorex.ATag OptionDropdown
            {
                get
                {
                    return _optiondropdownInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The OptionDropdown item info.
            /// </summary>
            [RepositoryItemInfo("7249d480-75a7-4835-ab22-ba98d3ad3917")]
            public virtual RepoItemInfo OptionDropdownInfo
            {
                get
                {
                    return _optiondropdownInfo;
                }
            }

            /// <summary>
            /// The ATagGiaoBaiTập item.
            /// </summary>
            [RepositoryItem("519c3b44-e922-4ab3-bb69-f41d4e157b37")]
            public virtual Ranorex.ATag ATagGiaoBaiTập
            {
                get
                {
                    return _ataggiaobaitậpInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ATagGiaoBaiTập item info.
            /// </summary>
            [RepositoryItemInfo("519c3b44-e922-4ab3-bb69-f41d4e157b37")]
            public virtual RepoItemInfo ATagGiaoBaiTậpInfo
            {
                get
                {
                    return _ataggiaobaitậpInfo;
                }
            }

            /// <summary>
            /// The Đong item.
            /// </summary>
            [RepositoryItem("1ebb85c6-60f2-4854-8fa7-4df3d2ae97ba")]
            public virtual Ranorex.ButtonTag Đong
            {
                get
                {
                    return _đongInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The Đong item info.
            /// </summary>
            [RepositoryItemInfo("1ebb85c6-60f2-4854-8fa7-4df3d2ae97ba")]
            public virtual RepoItemInfo ĐongInfo
            {
                get
                {
                    return _đongInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
