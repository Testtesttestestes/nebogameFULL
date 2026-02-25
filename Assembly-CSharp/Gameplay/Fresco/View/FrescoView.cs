using System;
using Gameplay.Fresco.View.Groups;
using Il2CppDummyDll;
using UI.Tabs;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007F9 RID: 2041
	[Token(Token = "0x20007F9")]
	public class FrescoView : MonoBehaviour
	{
		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000962")]
		public Button CollectionsButton
		{
			[Token(Token = "0x6002FF2")]
			[Address(RVA = "0x8058", Offset = "0x8058", VA = "0x8058")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002FF3 RID: 12275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000963")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6002FF3")]
			[Address(RVA = "0x8059", Offset = "0x8059", VA = "0x8059")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000964")]
		public FrescoGroupOSAView OSAView
		{
			[Token(Token = "0x6002FF4")]
			[Address(RVA = "0x805A", Offset = "0x805A", VA = "0x805A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF5")]
		[Address(RVA = "0x805B", Offset = "0x805B", VA = "0x805B")]
		private void Awake()
		{
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF6")]
		[Address(RVA = "0x805C", Offset = "0x805C", VA = "0x805C")]
		public FrescoView()
		{
		}

		// Token: 0x04001A39 RID: 6713
		[Token(Token = "0x4001A39")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _collectionsButton;

		// Token: 0x04001A3A RID: 6714
		[Token(Token = "0x4001A3A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04001A3B RID: 6715
		[Token(Token = "0x4001A3B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FrescoGroupOSAView _osaView;
	}
}
