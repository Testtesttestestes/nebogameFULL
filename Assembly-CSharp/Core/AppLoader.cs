using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Il2CppDummyDll;
using Preloading;
using UI;
using UnityEngine;

namespace Core
{
	// Token: 0x02000E56 RID: 3670
	[Token(Token = "0x2000E56")]
	public class AppLoader : MonoBehaviour
	{
		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x060059D3 RID: 22995 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700124B")]
		public AppCanvas AppCanvas
		{
			[Token(Token = "0x60059D3")]
			[Address(RVA = "0xA6FB", Offset = "0xA6FB", VA = "0xA6FB")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400021C RID: 540
		// (add) Token: 0x060059D4 RID: 22996 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060059D5 RID: 22997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400021C")]
		public event Action OnApplicationQuitEvent
		{
			[Token(Token = "0x60059D4")]
			[Address(RVA = "0xA6FC", Offset = "0xA6FC", VA = "0xA6FC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60059D5")]
			[Address(RVA = "0xA6FD", Offset = "0xA6FD", VA = "0xA6FD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400021D RID: 541
		// (add) Token: 0x060059D6 RID: 22998 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060059D7 RID: 22999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400021D")]
		public event Action<bool> OnApplicationFocusEvent
		{
			[Token(Token = "0x60059D6")]
			[Address(RVA = "0xA6FE", Offset = "0xA6FE", VA = "0xA6FE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60059D7")]
			[Address(RVA = "0xA6FF", Offset = "0xA6FF", VA = "0xA6FF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x060059D8 RID: 23000 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060059D9 RID: 23001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700124C")]
		public Preloader Preloader
		{
			[Token(Token = "0x60059D8")]
			[Address(RVA = "0xA700", Offset = "0xA700", VA = "0xA700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60059D9")]
			[Address(RVA = "0xA701", Offset = "0xA701", VA = "0xA701")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DA")]
		[Address(RVA = "0xA702", Offset = "0xA702", VA = "0xA702")]
		private void Awake()
		{
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DB")]
		[Address(RVA = "0xA703", Offset = "0xA703", VA = "0xA703")]
		private void Start()
		{
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DC")]
		[Address(RVA = "0xA704", Offset = "0xA704", VA = "0xA704")]
		private void InstanceOnInitCompleteEvent(IApp app)
		{
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DD")]
		[Address(RVA = "0xA705", Offset = "0xA705", VA = "0xA705")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DE")]
		[Address(RVA = "0xA706", Offset = "0xA706", VA = "0xA706")]
		private void OnApplicationFocus(bool focus)
		{
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DF")]
		[Address(RVA = "0xA707", Offset = "0xA707", VA = "0xA707")]
		public AppLoader()
		{
		}

		// Token: 0x04003097 RID: 12439
		[Token(Token = "0x4003097")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AppCanvas appCanvas;
	}
}
