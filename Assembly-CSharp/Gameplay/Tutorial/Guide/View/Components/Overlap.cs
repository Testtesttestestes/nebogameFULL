using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Tutorial.Guide.View.Components
{
	// Token: 0x02000475 RID: 1141
	[Token(Token = "0x2000475")]
	public class Overlap : MonoBehaviourWithStates<OverlapType>, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000131 RID: 305
		// (add) Token: 0x06001AFF RID: 6911 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001B00 RID: 6912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000131")]
		public event Action ClickEvent
		{
			[Token(Token = "0x6001AFF")]
			[Address(RVA = "0x6C89", Offset = "0x6C89", VA = "0x6C89")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001B00")]
			[Address(RVA = "0x6C8A", Offset = "0x6C8A", VA = "0x6C8A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B01")]
		[Address(RVA = "0x6C8B", Offset = "0x6C8B", VA = "0x6C8B")]
		private void Awake()
		{
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B02")]
		[Address(RVA = "0x6C8C", Offset = "0x6C8C", VA = "0x6C8C", Slot = "4")]
		protected override void HandleCurrentStateChanged(OverlapType fromState, OverlapType toState)
		{
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x6C8D", Offset = "0x6C8D", VA = "0x6C8D")]
		public void SetShadeAlpha(float alpha)
		{
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x6C8E", Offset = "0x6C8E", VA = "0x6C8E", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x6C8F", Offset = "0x6C8F", VA = "0x6C8F")]
		public Overlap()
		{
		}

		// Token: 0x04000E8C RID: 3724
		[Token(Token = "0x4000E8C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _image;

		// Token: 0x04000E8D RID: 3725
		[Token(Token = "0x4000E8D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _balackShadeColor;

		// Token: 0x04000E8E RID: 3726
		[Token(Token = "0x4000E8E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _transparentColor;
	}
}
