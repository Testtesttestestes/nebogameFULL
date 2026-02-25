using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BD0 RID: 3024
	[Token(Token = "0x2000BD0")]
	public abstract class TournamentListElementBase : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IDisposable
	{
		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06004A19 RID: 18969 RVA: 0x0000DA40 File Offset: 0x0000BC40
		// (set) Token: 0x06004A1A RID: 18970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EFD")]
		public int Index
		{
			[Token(Token = "0x6004A19")]
			[Address(RVA = "0x987B", Offset = "0x987B", VA = "0x987B")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004A1A")]
			[Address(RVA = "0x987C", Offset = "0x987C", VA = "0x987C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A1B")]
		[Address(RVA = "0x987D", Offset = "0x987D", VA = "0x987D", Slot = "6")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A1C")]
		[Address(RVA = "0x987E", Offset = "0x987E", VA = "0x987E", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A1D")]
		[Address(RVA = "0x987F", Offset = "0x987F", VA = "0x987F", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A1E")]
		[Address(RVA = "0x9880", Offset = "0x9880", VA = "0x9880")]
		protected TournamentListElementBase()
		{
		}

		// Token: 0x0400285F RID: 10335
		[Token(Token = "0x400285F")]
		[FieldOffset(Offset = "0x10")]
		public Action<TournamentListElementBase> ClickEventHandler;
	}
}
