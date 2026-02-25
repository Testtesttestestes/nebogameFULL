using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Medals.Controller;
using Gameplay.Medals.Events;
using Gameplay.Medals.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200116A RID: 4458
	[Token(Token = "0x200116A")]
	public class MedalsManager : IGameManager, IBaseManager
	{
		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06006946 RID: 26950 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700158A")]
		public string Name
		{
			[Token(Token = "0x6006946")]
			[Address(RVA = "0xB46A", Offset = "0xB46A", VA = "0xB46A", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400028C RID: 652
		// (add) Token: 0x06006947 RID: 26951 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006948 RID: 26952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400028C")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006947")]
			[Address(RVA = "0xB46B", Offset = "0xB46B", VA = "0xB46B", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006948")]
			[Address(RVA = "0xB46C", Offset = "0xB46C", VA = "0xB46C", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400028D RID: 653
		// (add) Token: 0x06006949 RID: 26953 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600694A RID: 26954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400028D")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006949")]
			[Address(RVA = "0xB46D", Offset = "0xB46D", VA = "0xB46D", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600694A")]
			[Address(RVA = "0xB46E", Offset = "0xB46E", VA = "0xB46E", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x0600694B RID: 26955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700158B")]
		public MedalsController Controller
		{
			[Token(Token = "0x600694B")]
			[Address(RVA = "0xB46F", Offset = "0xB46F", VA = "0xB46F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x0600694C RID: 26956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700158C")]
		public MedalsModel Model
		{
			[Token(Token = "0x600694C")]
			[Address(RVA = "0xB470", Offset = "0xB470", VA = "0xB470")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x0600694D RID: 26957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700158D")]
		public MedalsEvents Events
		{
			[Token(Token = "0x600694D")]
			[Address(RVA = "0xB471", Offset = "0xB471", VA = "0xB471")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x0600694E RID: 26958 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600694F RID: 26959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700158E")]
		public MedalDicGroupStorage MedalDicGroupStorage
		{
			[Token(Token = "0x600694E")]
			[Address(RVA = "0xB472", Offset = "0xB472", VA = "0xB472")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600694F")]
			[Address(RVA = "0xB473", Offset = "0xB473", VA = "0xB473")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006950")]
		[Address(RVA = "0xB474", Offset = "0xB474", VA = "0xB474", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006951")]
		[Address(RVA = "0xB475", Offset = "0xB475", VA = "0xB475")]
		private void SetupMvc()
		{
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006952")]
		[Address(RVA = "0xB476", Offset = "0xB476", VA = "0xB476")]
		private void DestroyMvc()
		{
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006953")]
		[Address(RVA = "0xB477", Offset = "0xB477", VA = "0xB477")]
		private void ControllerInitEvent()
		{
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006954")]
		[Address(RVA = "0xB478", Offset = "0xB478", VA = "0xB478", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006955 RID: 26965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006955")]
		[Address(RVA = "0xB479", Offset = "0xB479", VA = "0xB479")]
		public void ShowOwnMedalInfoWindow(MedalDic medalDic)
		{
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006956")]
		[Address(RVA = "0xB47A", Offset = "0xB47A", VA = "0xB47A")]
		public void ShowMedalInfoWindow(MedalData medalData, uint rankId, UserData user, UserData loggedUser)
		{
		}

		// Token: 0x06006957 RID: 26967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006957")]
		[Address(RVA = "0xB47B", Offset = "0xB47B", VA = "0xB47B")]
		public void ShowMedalInfoWindow(MedalData medalData, uint rankId, MedalsController controller)
		{
		}

		// Token: 0x06006958 RID: 26968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006958")]
		[Address(RVA = "0xB47C", Offset = "0xB47C", VA = "0xB47C")]
		public void ShowMedalsWindow()
		{
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006959")]
		[Address(RVA = "0xB47D", Offset = "0xB47D", VA = "0xB47D")]
		public void ShowMedalsWindow(Predicate<MedalData> customFilter)
		{
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600695A")]
		[Address(RVA = "0xB47E", Offset = "0xB47E", VA = "0xB47E")]
		public MedalsManager()
		{
		}

		// Token: 0x040037DF RID: 14303
		[Token(Token = "0x40037DF")]
		[FieldOffset(Offset = "0x10")]
		private MedalsController _controller;

		// Token: 0x040037E0 RID: 14304
		[Token(Token = "0x40037E0")]
		[FieldOffset(Offset = "0x14")]
		private MedalsModel _model;

		// Token: 0x040037E1 RID: 14305
		[Token(Token = "0x40037E1")]
		[FieldOffset(Offset = "0x18")]
		private MedalsEvents _events;
	}
}
