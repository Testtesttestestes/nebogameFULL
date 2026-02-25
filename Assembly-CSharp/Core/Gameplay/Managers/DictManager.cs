using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Dict;
using Core.Dict.Controller;
using Core.Dict.Controller.WebGL;
using Core.Dict.DictWrappers.Base;
using Core.Dict.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001163 RID: 4451
	[Token(Token = "0x2001163")]
	public class DictManager : IGameManager, IBaseManager, IDictProvider, IGameAssetProvider
	{
		// Token: 0x1400027D RID: 637
		// (add) Token: 0x060068DB RID: 26843 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068DC RID: 26844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400027D")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60068DB")]
			[Address(RVA = "0xB401", Offset = "0xB401", VA = "0xB401", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068DC")]
			[Address(RVA = "0xB402", Offset = "0xB402", VA = "0xB402", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400027E RID: 638
		// (add) Token: 0x060068DD RID: 26845 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068DE RID: 26846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400027E")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60068DD")]
			[Address(RVA = "0xB403", Offset = "0xB403", VA = "0xB403", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068DE")]
			[Address(RVA = "0xB404", Offset = "0xB404", VA = "0xB404", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x060068DF RID: 26847 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001574")]
		public string Name
		{
			[Token(Token = "0x60068DF")]
			[Address(RVA = "0xB405", Offset = "0xB405", VA = "0xB405", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x060068E0 RID: 26848 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068E1 RID: 26849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001575")]
		public DictController Controller
		{
			[Token(Token = "0x60068E0")]
			[Address(RVA = "0xB406", Offset = "0xB406", VA = "0xB406")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068E1")]
			[Address(RVA = "0xB407", Offset = "0xB407", VA = "0xB407")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x060068E2 RID: 26850 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068E3 RID: 26851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001576")]
		public DictModel Model
		{
			[Token(Token = "0x60068E2")]
			[Address(RVA = "0xB408", Offset = "0xB408", VA = "0xB408")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068E3")]
			[Address(RVA = "0xB409", Offset = "0xB409", VA = "0xB409")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x060068E4 RID: 26852 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068E5 RID: 26853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001577")]
		public DictEvents Events
		{
			[Token(Token = "0x60068E4")]
			[Address(RVA = "0xB40A", Offset = "0xB40A", VA = "0xB40A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068E5")]
			[Address(RVA = "0xB40B", Offset = "0xB40B", VA = "0xB40B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x060068E6 RID: 26854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001578")]
		public Dictionaries D
		{
			[Token(Token = "0x60068E6")]
			[Address(RVA = "0x1AAD", Offset = "0x1AAD", VA = "0x1AAD", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400027F RID: 639
		// (add) Token: 0x060068E7 RID: 26855 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068E8 RID: 26856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400027F")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x60068E7")]
			[Address(RVA = "0xB40C", Offset = "0xB40C", VA = "0xB40C", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068E8")]
			[Address(RVA = "0xB40D", Offset = "0xB40D", VA = "0xB40D", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x060068E9 RID: 26857 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068EA RID: 26858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001579")]
		public IApp App
		{
			[Token(Token = "0x60068E9")]
			[Address(RVA = "0xB40E", Offset = "0xB40E", VA = "0xB40E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068EA")]
			[Address(RVA = "0xB40F", Offset = "0xB40F", VA = "0xB40F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x060068EB RID: 26859 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068EC RID: 26860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700157A")]
		public DictWrappersStorage WrappersStorage
		{
			[Token(Token = "0x60068EB")]
			[Address(RVA = "0xB410", Offset = "0xB410", VA = "0xB410", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068EC")]
			[Address(RVA = "0xB411", Offset = "0xB411", VA = "0xB411")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068ED")]
		[Address(RVA = "0xB412", Offset = "0xB412", VA = "0xB412")]
		public DictManager(IApp app)
		{
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x00013938 File Offset: 0x00011B38
		[Token(Token = "0x60068EE")]
		[Address(RVA = "0xB413", Offset = "0xB413", VA = "0xB413")]
		public bool CheckSupportedService(Services serviceId)
		{
			return default(bool);
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60068EF")]
		[Address(RVA = "0x1D72", Offset = "0x1D72", VA = "0x1D72", Slot = "16")]
		public string GetAssetPath(string assetId)
		{
			return null;
		}

		// Token: 0x060068F0 RID: 26864 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60068F0")]
		[Address(RVA = "0xB414", Offset = "0xB414", VA = "0xB414", Slot = "15")]
		public AssetDic GetAsset(string assetId)
		{
			return null;
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F1")]
		[Address(RVA = "0xB415", Offset = "0xB415", VA = "0xB415", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F2")]
		[Address(RVA = "0xB416", Offset = "0xB416", VA = "0xB416")]
		private void InitEventHandler()
		{
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F3")]
		[Address(RVA = "0xB417", Offset = "0xB417", VA = "0xB417")]
		private void NotifyDictChanged()
		{
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F4")]
		[Address(RVA = "0xB418", Offset = "0xB418", VA = "0xB418", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F5")]
		[Address(RVA = "0xB419", Offset = "0xB419", VA = "0xB419")]
		private void ConfigureApp()
		{
		}

		// Token: 0x040037BA RID: 14266
		[Token(Token = "0x40037BA")]
		[FieldOffset(Offset = "0x28")]
		private string[] _supportedServices;
	}
}
